using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCameraPlayer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        if (!photonView.IsMine)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
