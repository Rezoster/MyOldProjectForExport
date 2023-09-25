using UnityEngine;

public class Conditions1 : MonoBehaviour
{    
    private Vector3 _emptyVector3;
    
    public void IncreaseAndImpulse(Rigidbody giveImpulse)
    {
        _emptyVector3 = transform.localScale;
        giveImpulse.useGravity = true;
        giveImpulse.AddForce(0, 40, 0, ForceMode.Impulse);
        transform.localScale = new Vector3(_emptyVector3.x + 1,_emptyVector3.y + 1, _emptyVector3.z + 1);
    }

    public void DestroyObj(GameObject objectDestroyed)
    {
        Destroy(objectDestroyed);
    }
}
