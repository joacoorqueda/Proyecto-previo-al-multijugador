using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoTamaño : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(x: 1f, y: 1f, z: 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Token"))
        {
            
         transform.localScale += new Vector3(x:0.1f, y: 0.1f, z: 0.1f);
            

        }


    }
}
