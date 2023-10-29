using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    [SerializeField] private Transform target;
    public static UnityEvent ActivateTriggerBombDeath = new UnityEvent();
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            ActivateTriggerBombDeath.Invoke();
        }


    }
}
