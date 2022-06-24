using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    private void Update()
    {
        transform.position = new Vector3(0, Target.position.y, -10f);
    }
}
