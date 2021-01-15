using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }


    private void LateUpdate()
    {
   
        Vector3 position = transform.position;
        if (player)
            position.y = (player.transform.position + offset).y;
            transform.position = position;
    }
}


