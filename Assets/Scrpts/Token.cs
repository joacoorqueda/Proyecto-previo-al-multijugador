using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update

    Inventar tamanio;
    //public string Tag;
    //public Text Letters;

    //int puntuacion = 0;

    void Start()
    {
        tamanio = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventar>();

    } 

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            tamanio.tamaño = tamanio.tamaño + 1;
            Destroy(gameObject);
            transform.localScale += new Vector3(x: 0.02f, y: 0f, z: 0.02f);

            //puntuacion += 10;
            //Letters.text = "Score: " + puntuacion;

        }


    }
}
