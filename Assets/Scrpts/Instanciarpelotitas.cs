using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarpelotitas : MonoBehaviour
{
    public int InventarioPelotitas;

    public GameObject Tokenp;


    int I;

    public float rangoGeneracion, cantidadAGenerar;

    // Start is called before the first frame update
    void Start()
    {
        for (I = 0 ; I < cantidadAGenerar; I++/*, posXGeneracion += 5.0f, posZGeneracion+= 5.0f*/)
        {
            float posXGeneracion =Random.Range(-rangoGeneracion, rangoGeneracion);
            float posZGeneracion =Random.Range(-rangoGeneracion, rangoGeneracion);
            Vector3 posinstanciacion = new Vector3(posXGeneracion, 0.82f, posZGeneracion);
            //posZGeneracion += 5.0f;
            //posXGeneracion += 5.0f;
            Instantiate(Tokenp, posinstanciacion, Tokenp.transform.rotation);
        }
    }
    
//posXGeneracion += 5.0f;

            //posZGeneracion += 5.0f;
    // Update is called once per frame
    void Update()
    {
        
    }
}
