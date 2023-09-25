using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] private Transform elevator;
    [SerializeField] private Transform floor;
    private Vector3 variable;
    private bool down;
    private void OnCollisionStay(Collision collision)
    {
        Elevation("up", elevator, 0.2f);
        down = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        down = true;
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(elevator.position, floor.position) >= 1 && down)
            Elevation("down", elevator, 0.4f);
    }

    private void Elevation(string direction, Transform elevator, float speed)
    {
        variable = elevator.position;
        if (direction == "up")
            variable = new Vector3(variable.x, variable.y + speed, variable.z);
        if (direction == "down")
            variable = new Vector3(variable.x, variable.y - speed, variable.z);
        elevator.position = variable;
    }
}
