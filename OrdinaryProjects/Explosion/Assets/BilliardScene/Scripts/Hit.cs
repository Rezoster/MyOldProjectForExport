using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private AudioSource hitBalls;
    [SerializeField] private int quantityBalls;
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < quantityBalls; i++)
            if (collision.gameObject.name == $"Ball_{i}" || collision.gameObject.name == "Ball_00")
                hitBalls.Play();
    }
}
