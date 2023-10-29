using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float amountOfMana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (other.gameObject.GetComponentInParent<Enemy>())
            {
                Attack(other.gameObject);
            }
        }
    }

    private void Attack(GameObject enemy)
    {
        Destroy(enemy.gameObject);
    }
}
