using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;

    public Transform spawnPoint;

    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    Vida_Avion planelife;

    Inventar tamanio;

    public int VidaAvionn = 0;

    void Update()
    {
        if (VidaAvionn <= 0)
        {
            Destroy(gameObject);

        }

        planelife = GameObject.FindGameObjectWithTag("Player").GetComponent<Vida_Avion>();

        tamanio = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventar>();


        if (VidaAvionn >= 100)
        {



            if (Input.GetKey(KeyCode.Mouse0))
            {

                if (Time.time > shotRateTime)
                {
                    GameObject newBullet;
                    newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                    //newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                    shotRateTime = Time.time + shotRate;

                    transform.localScale -= new Vector3(x: 0.009f, y: 0f, z: 0.009f);

                    planelife.VidaAvionn = planelife.VidaAvionn - 1;

                    tamanio.tamaño = tamanio.tamaño - 1;

                }



            }
        }
    }
}

