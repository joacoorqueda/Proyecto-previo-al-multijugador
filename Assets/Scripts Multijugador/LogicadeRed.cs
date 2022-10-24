﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LogicadeRed : MonoBehaviourPunCallbacks
{
    public static LogicadeRed instancia;

    void Awake()
    {
        instancia = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Felicidades estas conectado");
    }
}