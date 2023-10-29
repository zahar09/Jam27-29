using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    void Update()
    {
        transform.LookAt(_target.transform);
    }
}
