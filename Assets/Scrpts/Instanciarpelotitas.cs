﻿using System.Collections;
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

        float posXGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);

        float posZGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);

        Vector3 posinstanciacion = new Vector3(posXGeneracion , 0.82f , posZGeneracion );



       

        for (InventarioPelotitas = 0; I < 200; I++)
        {
             Instantiate(Tokenp, posinstanciacion, Tokenp.transform.rotation);

            posXGeneracion++;
            InventarioPelotitas++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
