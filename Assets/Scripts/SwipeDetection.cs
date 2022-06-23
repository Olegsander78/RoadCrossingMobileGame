using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public Player Player;
    private Vector2 _startPos;
    public int PixelDistToDetect = 20;
    private bool _fingerDown;

    private void Update()
    {
        if (_fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            _startPos = Input.touches[0].position;
            _fingerDown = true;
        }

            if (_fingerDown)
            {
                if (Input.touches[0].position.y >= _startPos.y + PixelDistToDetect)
                {
                    _fingerDown = false;
                    Debug.Log("Swipe Up");
                }
            }
        

        if (_fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            _fingerDown = false;
        }

        //TESTING FOR PC

        if (_fingerDown == false && Input.GetMouseButtonDown(0))
        {
            _startPos = Input.mousePosition;
            _fingerDown = true;
        }

            if (_fingerDown)
            {
                if (Input.mousePosition.y >= _startPos.y + PixelDistToDetect)
                {
                    _fingerDown = false;
                    Debug.Log("Swipe Up");
                }
            }

            if(_fingerDown && Input.GetMouseButtonUp(0))
            {
            _fingerDown = false;
            }
    }

}
