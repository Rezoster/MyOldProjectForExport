using UnityEngine;
using Random = UnityEngine.Random;

public class Randoms : MonoBehaviour
{
    [SerializeField] private Animator firstAnima;
    [SerializeField] private Animator secondPartFirstAnima;
    [SerializeField] private Animator secondPartSecondAnima;
    [SerializeField] private Animator thirdAnima;
    private int returnRandom;
    void Start()
    {
        Stopped();
    }

    private int GetRandom()
    {
        returnRandom = Random.Range(0, 3);
        return returnRandom;
    }

    private void StartAnima()
    {
        switch (GetRandom())
        {
            case 0:
                firstAnima.Play("TwisterAnimation");
                break;
            case 1:
                secondPartFirstAnima.Play("GateAnimation");
                secondPartSecondAnima.Play("GateAnimation");
                break;
            case 2:
                thirdAnima.Play("HammerAnimation");
                break;
        }

    }

    private void Stopped()
    {
        //firstAnima.StartPlayback();
        secondPartFirstAnima.StartPlayback();
        secondPartSecondAnima.StartPlayback();
        thirdAnima.StartPlayback();
    }
}
