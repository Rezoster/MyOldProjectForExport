using UnityEngine;
using HVJ;
using Unity.VisualScripting;

public class RollUpGate : MonoBehaviour
{
    [SerializeField] private GameObject pleasePress;
    [SerializeField] private GameObject destructionGate;
    [SerializeField] private GameObject destructionButton;
    [SerializeField] private Animator active;
    [SerializeField] private GameObject barrierBetweenLocations; // So that the player doesn't move to another place

    private void Messenger(bool changeWay) // Select activate or deactivate text
    {
        pleasePress.SetActive(changeWay);
    }

    private void Delete()
    {
        Destroy(destructionGate);
        Destroy(destructionButton);
        barrierBetweenLocations.SetActive(true);
    }

    private void OnCollisionStay(Collision collision)
    {
        Messenger(true);
        if (Input.GetKeyDown(GlobalAxis.rollUp))
            active.SetBool("ConditionGate", true);
    }

    private void OnCollisionExit(Collision collision)
    {
        Messenger(false);
    }


}
