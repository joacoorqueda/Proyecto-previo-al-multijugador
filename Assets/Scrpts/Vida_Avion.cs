using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Avion : MonoBehaviour
{
    public int VidaAvionn;

    private void Update()
    {
        if (VidaAvionn <= 0)
        {
            Destroy(gameObject);
            
        }

    }
}
