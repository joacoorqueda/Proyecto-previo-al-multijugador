using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;

    public Transform spawnPoint;

    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                //newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                shotRateTime = Time.time + shotRate;

            }
        }
    }
}
