using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Soul : MonoBehaviour
{
    
    [SerializeField, Range(1f, 10f)] private float speed;
    private bool IsMove;
    private GameObject plyer;
    // Start is called before the first frame update
    private void Start()
    {
        IsMove = false;
    }
    public void FollowTheObject(GameObject _object)
    {
        IsMove = true;
        plyer = _object;
    }
    private void Update()
    {
        if (IsMove)
        {
            float step = speed * Time.deltaTime;

            // Переместите нашу позицию на шаг ближе к цели.
            transform.position = Vector3.MoveTowards(transform.position, plyer.transform.position, step);
        }
    }
    public void StopFollow()
    {
        IsMove = false;
    }

}
