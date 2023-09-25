using UnityEngine;

public class ActiveHeal : MonoBehaviour
{
    [SerializeField] private Health healing;
    [SerializeField] private Animator heal;
    private bool active;

    public void ActivateSkipAnimation(bool activete)
    {
        active = activete;
    }

    private void ActiveAnimation()
    {
        if (active)
        {
            heal.SetInteger("Condition", 1);
            active = false;
        }
    }

    private void Destroyed()
    {
        healing.Healing();
        Destroy(gameObject);
    }
}
