using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private const string Player = "Players", Checker = "Checker";

    [SerializeField] private ActivePlatform activeAvimation;
    [SerializeField] private Animator respawnPlayer;
    [SerializeField] private PlayerControll newPosition;
    [SerializeField] private GameObject colorCheckpoint;
    [SerializeField] private NextOrReloadLevel restart;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Rigidbody player;
    [SerializeField] private Transform position;
    private bool ativeCheckpoint = false;
    private bool disactivateRestart = false;
    private bool playerExitTrigger = true;

    public void SavePosition()
    {
        if (position.gameObject.activeSelf && disactivateRestart)
        {
            newPosition.RestartCheckpoint(position);
            Debug.Log(1);
        }
        else
            restart.Restart();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(Player) && playerExitTrigger)
        {
            disactivateRestart = true;
            ativeCheckpoint = true;
            ActivateRigidbody();
            playerExitTrigger = false;
        }
        if (player.constraints == RigidbodyConstraints.FreezePosition)
            player.constraints = RigidbodyConstraints.None;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(Player))
            playerExitTrigger = true;
    }

    private void ActivateRigidbody()
    {
        if (ativeCheckpoint)
        {
            SavePosition();
            player.constraints = RigidbodyConstraints.FreezePosition;
            ActivateRespawn();
            player.constraints = RigidbodyConstraints.None;
            ativeCheckpoint = false;
        }
    }

    private void ActivateRespawn()
    {
        activeAvimation.ActiveAnimatore(respawnPlayer, Checker, ativeCheckpoint);
    }

}
