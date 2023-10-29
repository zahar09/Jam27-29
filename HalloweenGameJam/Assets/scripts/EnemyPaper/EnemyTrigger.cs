using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

public class EnemyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
=======
using UnityEngine.Events;

public class EnemyTrigger : MonoBehaviour
{
    public static UnityEvent ActivateTriggerEnemyPaper = new UnityEvent();
>>>>>>> Stashed changes
    void Start()
    {
        
    }

<<<<<<< Updated upstream
    // Update is called once per frame
=======
    
>>>>>>> Stashed changes
    void Update()
    {
        
    }
<<<<<<< Updated upstream
=======

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateTriggerEnemyPaper.Invoke();
            print("Zarabotalo");
        }
    }
>>>>>>> Stashed changes
}
