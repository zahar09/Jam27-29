
using UnityEngine;
using UnityEngine.Events;

public class EnemyTrigger : MonoBehaviour
{
    

    public static UnityEvent ActivateTriggerEnemyPaper = new UnityEvent();

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
            ActivateTriggerEnemyPaper.Invoke();
            print("Zarabotalo");
        }
    }

}
