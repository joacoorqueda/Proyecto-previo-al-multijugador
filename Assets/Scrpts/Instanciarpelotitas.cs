using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarpelotitas : MonoBehaviour
{
    public int InventarioPelotitas;

    public GameObject Tokenp;

    int I;


    private float rangoGeneracion = 6f/*400f*/;

    // Start is called before the first frame update
    void Start()
    {

        float posXGeneracion = 5.0f;       /*Random.Range(-rangoGeneracion, rangoGeneracion);*/

        float posZGeneracion = 5.0f;             /*Random.Range(-rangoGeneracion, rangoGeneracion);*/

        Vector3 posinstanciacion = new Vector3(posXGeneracion, 0.82f, posZGeneracion);







       for (I = 0; I < 100; I++)
            {
            posXGeneracion += 5.0f;
            posZGeneracion += 5.0f;

            InventarioPelotitas++;

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
