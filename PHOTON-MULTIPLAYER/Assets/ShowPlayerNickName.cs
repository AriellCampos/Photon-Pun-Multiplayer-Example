using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerNickName : MonoBehaviourPunCallbacks
{
    private Camera playerCamera;  // Refer�ncia � c�mera do jogador

    void Start()
    {
        // Definindo o nome do jogador
        GetComponent<Text>().text = photonView.Owner.NickName.Split(" | ")[0];
        Debug.Log(photonView.Owner.NickName.Split(" | "));

        // Procurando a c�mera do jogador
        playerCamera = Camera.main;
    }

    void Update()
    {
        if (playerCamera != null && !photonView.IsMine)
        {
            // Faz o nome olhar para a c�mera, com rota��o adequada
            transform.LookAt(playerCamera.transform.position);

            // Mant�m a rota��o correta, apenas para n�o inverter o nome
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            eulerRotation.x = 0;  // Previne a rota��o no eixo X
            eulerRotation.z = 0;  // Previne a rota��o no eixo Z
            transform.rotation = Quaternion.Euler(eulerRotation);
        }
    }
}
