using UnityEngine;

public class FulfillmentCondition : MonoBehaviour
{
    [SerializeField] private Animator condition;

    private void OnCollisionEnter(Collision collision)
    {
        condition.SetBool("Conditions", true);
    }
}
