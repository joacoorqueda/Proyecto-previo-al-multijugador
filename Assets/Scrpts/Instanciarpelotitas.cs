using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarpelotitas : MonoBehaviour
{
    public int InventarioPelotitas;

    public GameObject Tokenp;

 
    private float rangoGeneracion = 9.0f;

    // Start is called before the first frame update
    void Start()
    {

        float posXGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);

        float posZGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);

        Vector3 posinstanciacion = new Vector3(posXGeneracion , 0.82f , posZGeneracion );





        for (int I = 0; I < 100; I++)
        {
            Instantiate(Tokenp, posinstanciacion, Tokenp.transform.rotation);

            InventarioPelotitas++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
