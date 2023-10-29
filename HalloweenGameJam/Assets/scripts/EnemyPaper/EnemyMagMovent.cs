using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMagMovent : MonoBehaviour
{
    public List<Transform> patrolPoints;
    public float speed = 2f;
    private int currentPatrolPointIndex = 0;
    [SerializeField] private bool _isActive = true;
    [SerializeField] private Animator _animator;


    private void Update()
    {
        EnemyMagTrigger.ActivateTriggerEnemyMag.AddListener(InRange);
        Patrol();
    }

    private void Patrol()
    {
        
        if (patrolPoints.Count == 0) return;
        
        if (_isActive == true)
        {
            Transform targetPatrolPoint = patrolPoints[currentPatrolPointIndex];
            Vector3 direction = targetPatrolPoint.position - transform.position;
            float distance = direction.magnitude;

            if (distance < 0.1f)
            {
                currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Count;

            }
            else
            {
                transform.position += direction.normalized * speed * Time.deltaTime;
            }
        }

    }

    private void InRange()
    {
        _animator.SetBool("IsIdle", true);
        _isActive = false;
    }
}
