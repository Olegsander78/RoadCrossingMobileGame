using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public int EdgeDistance;
    private Vector3 _targetPos;

    private void Start()
    {
        _targetPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPos, MoveSpeed * Time.deltaTime);

    }
    public void Move(Vector3 moveDirection)
    {
        if (Mathf.Abs(_targetPos.x + moveDirection.x) > EdgeDistance)
        {
            return;
        }
        _targetPos += moveDirection;
    }
}
