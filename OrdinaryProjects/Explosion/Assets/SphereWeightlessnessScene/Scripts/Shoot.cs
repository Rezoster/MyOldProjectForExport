using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Rigidbody cartridge;
    [SerializeField] private Transform cartrider;
    [SerializeField] private bool activateClone;
    private float intervalTime = 2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activateClone)
        {
            intervalTime -= Time.deltaTime;
            if (intervalTime <= 0)
            {
                Rigidbody clone;
                clone = Instantiate(cartridge, cartrider.position, cartrider.rotation);
                clone.AddForce(30, 0, 0, ForceMode.Impulse);
                clone.useGravity = true;
                intervalTime = 2;
            }
        }
    }
}
