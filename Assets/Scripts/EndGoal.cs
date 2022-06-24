using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TryGetComponent<Player>(out Player player);
        player?.Win();
    }
}
