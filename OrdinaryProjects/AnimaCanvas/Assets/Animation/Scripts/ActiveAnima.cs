using UnityEngine;
using Random = UnityEngine.Random;

public class ActiveAnima : StateMachineBehaviour
{
    private Animator changeAnima;
    private int returnRandom;

    void Start()
    {
    }
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
