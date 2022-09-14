using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarpelotitas : MonoBehaviour
{
    public GameObject TokenP;

    private float rangoGeneracion = 9.0f;

    // Start is called before the first frame update
    void Start()
    {

        float posXGeneracion = Random.Range(rangoGeneracion, rangoGeneracion);

        float posZGeneracion = Random.Range(rangoGeneracion, rangoGeneracion);

        Vector3 posAleatoria = new Vector3(posXGeneracion, 1, posZGeneracion);

        Instantiate(TokenP, posAleatoria, TokenP.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
