using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleLauncher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;

    public InputField playerNickName;
    public GameObject nickNameInput;

    public string chosenAvatar = "AvatarOne";
    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room.");
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
    }

    public void StartTheGame()
    {
        PhotonNetwork.NickName = playerNickName.text + " | " + chosenAvatar;
        PhotonNetwork.ConnectUsingSettings();

        nickNameInput.SetActive(false);
    }

    public void SetAvatar(string avatarName)
    {
        chosenAvatar = avatarName;
    }
}
