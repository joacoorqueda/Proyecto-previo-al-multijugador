using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update

    Inventar tamanio;

    void Start()
    {
        tamanio = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            tamanio.tamaño = tamanio.tamaño + 1;
            Destroy(gameObject);
            

        }


    }
}
