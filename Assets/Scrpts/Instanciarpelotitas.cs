﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instanciarpelotitas : MonoBehaviour
{
    
    

    public GameObject Tokenp;
   
   TextMeshProUGUI PlayerSize;

   

    int I;

    public float rangoGeneracion, cantidadAGenerar;

    // Start is called before the first frame update
    void Start()

    {
       


        for (I = 0 ; I < cantidadAGenerar; I++)
        {
            float posXGeneracion =Random.Range(-rangoGeneracion, rangoGeneracion);
            float posZGeneracion =Random.Range(-rangoGeneracion, rangoGeneracion);
            Vector3 posinstanciacion = new Vector3(posXGeneracion, 0.82f, posZGeneracion);
            
            Instantiate(Tokenp, posinstanciacion, Tokenp.transform.rotation);
        }

        PlayerSize.text = ;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
