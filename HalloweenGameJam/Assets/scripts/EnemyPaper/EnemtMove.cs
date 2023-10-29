using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtMove : MonoBehaviour
{
    public List<Transform> patrolPoints;
    public float speed = 2f;
    private int currentPatrolPointIndex = 0;
    [SerializeField] private bool _isActive = true;
    [SerializeField] private GameObject player;
    [SerializeField] private float attractiveSpeed;

    private bool IsMovingToPlayer;

    private void Start()
    {
        IsMovingToPlayer = false;
        EventManager.PaperHit += OnHit;
    }
    private void Update()
    {
        if (IsMovingToPlayer)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position, player.transform.position, Time.deltaTime * attractiveSpeed);
        }
        EnemyTrigger.ActivateTriggerEnemyPaper.AddListener(InRange);
        Patrol();
    }

    private void Patrol()
    {
        if (patrolPoints.Count == 0) return;

        if(_isActive == true)
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
        _isActive = false;
    }

    private void OnHit()
    {
        gameObject.gameObject.GetComponentInChildren<FrowBullet>().Shoot();
        IsMovingToPlayer = true;
        Debug.Log("hgghghgh");
    }
}
