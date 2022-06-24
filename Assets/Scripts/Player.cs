using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public int EdgeDistance;
    private Vector3 _targetPos;
    public int Score;

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

    public void AddScore(int amount)
    {
        Score += amount;
        UI.Instance.UpdateScoreText(Score);
    }

    public void GameOver()
    {
        UI.Instance.SetEndScreen(false);
    }

    public void Win()
    {
        UI.Instance.SetEndScreen(true);
    }
}
