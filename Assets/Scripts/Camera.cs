using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        //카메라가 플레이어를 따라 다니게 함
        transform.position = target.position + offset;
    }
}
