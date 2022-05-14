using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform = null;

    [SerializeField]
    private Vector2 offset = Vector2.zero;

    [SerializeField]
    private bool lockX = false;

    [SerializeField]
    private bool lockY = false;

    private void LateUpdate()
    {
        if (lockX)
        {
            transform.position = new Vector3(transform.position.x, targetTransform.position.y + offset.y, -10f);
        }
        else if (lockY)
        {
            transform.position = new Vector3(targetTransform.position.x + offset.x, transform.position.y, -10f);
        }
        else 
            transform.position = new Vector3(targetTransform.position.x + offset.x, targetTransform.position.y + offset.y, -10f);
    }
}
