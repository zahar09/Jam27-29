using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GetSouls : MonoBehaviour
{
    [SerializeField] private string TagOfSoul;
    [SerializeField] private GameObject ghostPosition;
    private int our_souls = 0;
    private bool CanCollectSouls;
    private bool HaveGhostNow;
    private Soul PickedSoul;
    private void Start()
    {
        HaveGhostNow = false;
        EventManager.ChangeState += OnChangeState;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.GetComponentInParent<Soul>() && CanCollectSouls && !HaveGhostNow)
        {
            TakeSoul(collision.gameObject.GetComponentInParent<Soul>());
        }
        if(collision.gameObject == this.gameObject.GetComponent<PlayerStatesManager>().body && HaveGhostNow)
        {
            OnCollectSoul(PickedSoul.gameObject);
        }
    }
    private void TakeSoul(Soul soul)
    {
        //our_souls++;
        //Destroy(soul);
        HaveGhostNow = true;
        PickedSoul = soul;
        soul.FollowTheObject(ghostPosition);

    }

    private void OnChangeState()
    {
        CanCollectSouls = !CanCollectSouls;
        if (!CanCollectSouls)
        {
            if(PickedSoul != null)
            {
                PickedSoul.StopFollow();
            }
        }
        Debug.Log("CanCollectSouls: " + CanCollectSouls.ToString());
    }
    
    private void OnCollectSoul(GameObject soul)
    {
        our_souls++;
        Debug.Log("Collect Soul");
        Destroy(soul);
    }
}

    
