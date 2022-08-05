using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Damage : MonoBehaviour
{
    public int Damage;
    public GameObject Player;



    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            Player.GetComponent<Vida_Avion>().VidaAvionn -= Damage;
            Destroy(gameObject);

        }


    }

}