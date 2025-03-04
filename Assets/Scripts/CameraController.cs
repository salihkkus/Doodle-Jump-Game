using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
  
    private void FixedUpdate()
    {
        if(transform.position.y < target.position.y)
        {
            var position = transform.position;
            position.y = Mathf.Lerp(position.y , target.position.y, 05f);
            transform.position = position;
        }
    }
}
