using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class ButtonContinue : MonoBehaviour
{
    private const string PlayerPrefsNameKey = "PlayerName";

  

    public void CambiarEscena()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
