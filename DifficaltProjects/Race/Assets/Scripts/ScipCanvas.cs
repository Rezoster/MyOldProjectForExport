using HVJ;
using UnityEngine;

public class ScipCanvas : MonoBehaviour
{
    [SerializeField] private PlayerControll playerControll;
    [SerializeField] private Trigger trigger;
   public void OnClick()
    {
        Debug.Log(1);
        trigger.SetActiveCanvas();
        playerControll.Restart();
    }
}
