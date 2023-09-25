using System.Collections;
using UnityEngine;
using HVJ;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    [SerializeField] private PlayerControll playerControll;
    [SerializeField] private Collider player;
    [SerializeField] private GameObject canvas;

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        SetActiveCanvas(true);
    }

    public void SetActiveCanvas(bool active  = false)
    {
        canvas.SetActive(active);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
            StartCoroutine(Timer());
    }
}
