using UnityEngine;

public class SlectAnimation : MonoBehaviour
{
    [SerializeField] private Animator changeAnima;
    private int returnRandom;
    private int GetCountRandom()
    {
        returnRandom = Random.Range(0, 4);
        Debug.Log(returnRandom);
        return returnRandom;
    }

    private void ConfigureSelectAnima()
    {
        changeAnima.SetInteger("changeAnimation", GetCountRandom());
    }
}
