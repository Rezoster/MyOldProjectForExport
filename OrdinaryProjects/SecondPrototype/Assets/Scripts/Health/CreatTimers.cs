using System.Collections;
using UnityEngine;

public class CreatTimers : MonoBehaviour
{
    [SerializeField] private Health damage;
    public void HitGate()
    {
        StartCoroutine((IEnumerator)TimerDamage());
        damage.Damage();
    }

    private IEnumerable TimerDamage()
    {
        yield return new WaitForSeconds(3); 
        damage.Damage();
    }



}
