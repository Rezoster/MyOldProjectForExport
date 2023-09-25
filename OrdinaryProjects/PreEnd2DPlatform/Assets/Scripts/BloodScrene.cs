using UnityEngine;

public class BloodScrene : MonoBehaviour
{
    private const int Below100 = 4, Below75 = 3, Below50 = 2, Below25 = 1;
    private const string Condition = "Condition";

    [SerializeField] private Animator bloodScrene;
    [SerializeField] private Health heal;
    [SerializeField] private int health;

    private void PlayerHealth()
    {
        health = heal.ReturnHealth();
        if (health >= 75)
            SetAnimationBloodScrene(Below100);
        else if (health < 75 & health >= 50)
            SetAnimationBloodScrene(Below75);
        else if (health < 50 & health >= 25)
            SetAnimationBloodScrene(Below50);
        else if (health < 25)
            SetAnimationBloodScrene(Below25);
    }
    private void SetAnimationBloodScrene(int value)
    {
        bloodScrene.SetInteger(Condition, value);
    }

}
