using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrowBullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _force = 1000;
    [SerializeField] private float timeBetweebShoot;
    private bool IsHit;
    private float timeBShootNow;
    private void Start()
    {
        timeBShootNow = timeBetweebShoot;
        IsHit = true;
    }
    void Update()
    {
        if (!IsHit)
        {
            if(timeBShootNow <= 0)
            {
                ShotBullet();
                timeBShootNow = timeBetweebShoot;
            }
            else
            {
                timeBShootNow -= Time.deltaTime;
            }
        }
    }
    private void ShotBullet()
    {
        GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * _force);
        Destroy(bullet, 5);
    }

    public void Shoot()
    {
        IsHit = true;
    }

    public void StartShoot()
    {
        IsHit = false;
    }
}
