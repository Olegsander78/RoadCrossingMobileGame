using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
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
        _targetPos += moveDirection;
    }
}
