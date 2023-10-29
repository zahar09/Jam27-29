using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    [SerializeField] private Transform SpawnPos;
    [SerializeField] private GameObject Cube;
    [SerializeField] private bool _isActive1 = false;
    void Start()
    {
        StartCoroutine(spawnCD());
        EnemyMagTrigger.ActivateTriggerEnemyMag.AddListener(Yes1);
    }


    void Update()
    {
        StartCoroutine(spawnCD());
    }

    IEnumerator spawnCD()
    {
        if(_isActive1 == true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(Cube, SpawnPos.position, Quaternion.identity);
            
            Repeat();
        }
        
    }

    void Repeat()
    {
        StartCoroutine(spawnCD());
    }

    private void Yes1()
    {
        _isActive1 = true;
    }
}
