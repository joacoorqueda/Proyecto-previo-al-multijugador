using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Damage : MonoBehaviour
{
    public int Damage;
    public GameObject Player;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.GetComponent<Vida_Avion>().VidaAvionn -= Damage;
        }


    }

}