using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private NavMeshAgent agent;

    [Header("Speed Settings")]
    [SerializeField, Range(0f, 100f)] private float normalSpeed;
    [SerializeField, Range(0f, 100f)] private float ghostSpeed;

    
    
    [SerializeField] private Animator animator;
    [SerializeField] private float deviation;

    
    private bool IsGhost;
    public Vector3 pos;
    private bool IsMoving;
    // Update is called once per frame
    private void Start()
    {
        agent.speed = normalSpeed;
        EventManager.ChangeState += ChangeState;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MoveToPosition(hit.point);
            }
            
        }
        if (Vector3.Distance(pos, transform.position) <= 0 + deviation)
        {
            animator.SetBool("IsRun", false);

        }
        else
        {
            animator.SetBool("IsRun", true);
        }
        pos = transform.position;

    }


    private void ChangeState()
    {
        agent.SetDestination(gameObject.transform.position);
        IsGhost = !IsGhost;
        Debug.Log("IsGhost: " + IsGhost.ToString());
        if (IsGhost)
        {
            agent.speed = ghostSpeed;
        }
        else
        {
            agent.speed = normalSpeed;

        }
    }
    private void MoveToPosition(Vector3 position)
    {
        agent.SetDestination(position);
        //Debug.Log("yes");
    }
}


