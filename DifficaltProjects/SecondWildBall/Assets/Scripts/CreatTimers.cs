using System.Collections;
using UnityEngine;

public class CreatTimers : MonoBehaviour
{
    [SerializeField] private Health damage;

    private IEnumerable timerDamage()
    {
        yield return new WaitForSeconds(3); 
        damage.Damage();
    }


    public void HitGate()
    {
        StartCoroutine((IEnumerator)timerDamage());
        damage.Damage();
    }

}
