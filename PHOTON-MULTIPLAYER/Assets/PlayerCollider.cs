using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviourPunCallbacks
{
    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Bullet") && !photonView.IsMine)
        {
            Debug.Log("Tomou um tiro");
            SceneManager.LoadSceneAsync("GameOver")
        }

    }
}
