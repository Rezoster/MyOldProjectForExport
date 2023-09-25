using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private Animator flag;

    private void OnCollisionEnter(Collision collision)
    {
        flag.SetBool("ConditionTriangle",true);
    }

}
