
using UnityEngine;
using UnityEngine.Events;

public class EnemyTrigger : MonoBehaviour
    
{
    [SerializeField] private GameObject ShootPoint;
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
            ShootPoint.GetComponent<FrowBullet>().StartShoot();
            ActivateTriggerEnemyPaper.Invoke();
            print("Zarabotalo");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

}
