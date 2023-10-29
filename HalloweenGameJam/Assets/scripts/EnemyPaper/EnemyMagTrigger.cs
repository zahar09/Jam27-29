using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMagTrigger : MonoBehaviour
{
    public static UnityEvent ActivateTriggerEnemyMag = new UnityEvent();

    void Start()
    {

    }

    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateTriggerEnemyMag.Invoke();
            print("Zarabotalo");
        }
    }
}
