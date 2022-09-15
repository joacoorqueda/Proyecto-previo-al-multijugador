using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarpelotitas : MonoBehaviour
{
    public GameObject Tokenp;

    private float rangoGeneracion = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

        float posXGeneracion = Random.Range(rangoGeneracion, rangoGeneracion);

        float posZGeneracion = Random.Range(rangoGeneracion, rangoGeneracion);

        Vector3 posAleatoria = new Vector3(posXGeneracion, 1, posZGeneracion);

        Instantiate(Tokenp, posAleatoria, Tokenp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
