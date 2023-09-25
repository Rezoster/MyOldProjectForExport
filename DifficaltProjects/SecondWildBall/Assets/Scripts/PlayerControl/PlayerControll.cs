using UnityEngine;
using UnityEngine.SceneManagement;
using HVJ;

[RequireComponent(typeof(InputPlayerControll))]
public class PlayerControll : MonoBehaviour
{
    [SerializeField] private InputPlayerControll inputControll;
    private Vector3 direct;
    private float horisontal;
    private float vertical;

    public void Restart(int anotherScene = 0)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + anotherScene);
    }

    private void SettingMovement()
    {
        horisontal = Input.GetAxis(GlobalAxis.horisontAxis);
        vertical = Input.GetAxis(GlobalAxis.verticalAxis);

        direct = new Vector3(horisontal, 0, vertical).normalized;
    }


    private void Update()
    {
        SettingMovement();

        if (Input.GetKeyDown(GlobalAxis.restart))
            Restart();
    }

    private void FixedUpdate()
    {
        inputControll.MoveForce(direct);
    }


}
