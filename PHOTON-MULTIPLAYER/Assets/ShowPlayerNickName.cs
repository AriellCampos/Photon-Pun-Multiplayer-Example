using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerNickName : MonoBehaviourPunCallbacks
{
    private Camera playerCamera;  // Referência à câmera do jogador

    void Start()
    {
        // Definindo o nome do jogador
        GetComponent<Text>().text = photonView.Owner.NickName.Split(" | ")[0];
        Debug.Log(photonView.Owner.NickName.Split(" | "));

        // Procurando a câmera do jogador
        playerCamera = Camera.main;
    }

    void Update()
    {
        if (playerCamera != null && !photonView.IsMine)
        {
            // Faz o nome olhar para a câmera, com rotação adequada
            transform.LookAt(playerCamera.transform.position);

            // Mantém a rotação correta, apenas para não inverter o nome
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            eulerRotation.x = 0;  // Previne a rotação no eixo X
            eulerRotation.z = 0;  // Previne a rotação no eixo Z
            transform.rotation = Quaternion.Euler(eulerRotation);
        }
    }
}
