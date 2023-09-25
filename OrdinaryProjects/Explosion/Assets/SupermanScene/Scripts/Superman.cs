using UnityEngine;

public class Superman : MonoBehaviour
{
    [SerializeField] private Transform hero;
    [SerializeField] private Transform attackHand;
    [SerializeField] private Transform coordinatesHit;
    [SerializeField] private Transform[] people;
    private Transform goal;
    [SerializeField] private Rigidbody[] bodies;
    [SerializeField] private AudioSource attack;
    private int numberArray = 0;
    [SerializeField] private float speedAtacker;
    [SerializeField] private float strong;
    private bool isActive = true;

    private float Hit()
    {
        return Vector3.Distance(attackHand.position, coordinatesHit.position) * strong;
    }

    private void OnCollisionEnter(Collision collision)
    {
        bodies[numberArray].velocity = new Vector3(Hit(), Hit(), Hit());
        Debug.Log("Hit");
    }

    private void AttackedGoal()
    {
        attack.Play();
        if (numberArray < people.Length - 1)
            numberArray++;
        if(numberArray == people.Length - 2)
            isActive = false;
        hero.LookAt(people[numberArray].position);
    }

    private void ChangeGoal()
    {
        while (numberArray <= people.Length)
        {
            goal = people[numberArray];
            if (Vector3.Distance(goal.position, hero.position) <= 0.3)
                AttackedGoal();
            else break;


        }
    }

    private void LookAndMove()
    {
        for (int i = 0; i < people.Length; i++)
        {
            people[i].LookAt(hero.position);
        }
        attackHand.LookAt(people[numberArray].position);
        ChangeGoal();
        hero.position = Vector3.MoveTowards(hero.position, goal.position, speedAtacker);
    }

    void FixedUpdate()
    {
        if (isActive)
        {
            LookAndMove();
        }
        else
        {
            hero.position = Vector3.MoveTowards(hero.position, new Vector3(0, 0, 0), speedAtacker);
        }
    }

}
