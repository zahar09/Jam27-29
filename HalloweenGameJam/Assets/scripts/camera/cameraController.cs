using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.time);
    }
}
