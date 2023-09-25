using UnityEngine;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    [SerializeField] private Animator changeAnima;
    private int returnRandom;

    private int GetCountRandom()
    {
        returnRandom = Random.Range(0, 3);
        return returnRandom;
    }

    private void ConfigureSelectAnima()
    {
        changeAnima.SetInteger("SelectAnima", GetCountRandom());
    }
}
