using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispatchShot : MonoBehaviourPunCallbacks
{
    public GameObject bulletSpawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.K))
            {
                PhotonNetwork.Instantiate("Bullet", bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            }
        }
    }
}
