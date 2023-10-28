using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemy : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private string tagOfPlayer;
    [SerializeField, Range(0f, 100f)] private float speed;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent.speed = speed;
        player = GameObject.FindGameObjectsWithTag(tagOfPlayer)[0];
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
