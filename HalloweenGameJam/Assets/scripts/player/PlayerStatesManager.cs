using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatesManager : MonoBehaviour
{
    [Header("Ghost state")]
    public GameObject body;
    [SerializeField] private float maxTimeInGhostState;

    private float TimeInGhostState;
    private bool IsGhost;
    // Start is called before the first frame update
    void Start()
    {
        body.SetActive(false);
        IsGhost = false;
        TimeInGhostState = maxTimeInGhostState;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSate();
        }
        if (IsGhost)
        {
            if (TimeInGhostState > 0)
            {
                TimeInGhostState -= Time.deltaTime;
            }
            else
            {
                ChangeSate();
                TimeInGhostState = maxTimeInGhostState;
            }
        }
    }
    private void ChangeSate()
    {
        IsGhost = !IsGhost;
        if (IsGhost)
        {
            body.transform.position = this.gameObject.transform.position;
            body.SetActive(true);
        }
        else
        {
            this.gameObject.transform.position = body.transform.position;
            body.SetActive(false);
        }
        EventManager.OnChangeState();

    }

    public bool GetState()
    {
        return IsGhost;
    }
}
