using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Speed;
    public Vector3 StartPos;
    public Vector3 EndPos;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, EndPos, Speed * Time.deltaTime);

        if(transform.position == EndPos)
        {
            transform.position = StartPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TryGetComponent<Player>(out Player player);
        player?.GameOver();
    }
}
