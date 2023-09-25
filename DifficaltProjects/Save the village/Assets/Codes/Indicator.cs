using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    public Text warrior;
    public Text wave;
    public Text wheat;
    public Text peasant;

    private byte bWarrior;
    private byte bWave;
    private byte bWheat;
    private byte bPeasant;

    // Start is called before the first frame update
    void Start()
    {
        bWarrior += 2;
        warrior.text = $"Воинов: {bWarrior}";
    }

    private void Warrior()
    {
        bWarrior += 2;
        warrior.text = $"Воинов: {bWarrior}";
    }

    private void Peasant()
    {
        bPeasant += 4;
        peasant.text = $"Крестьяне: {bPeasant}";
    }

    private void Wheat()
    {
        wheat.text = $"Пшеница: {bPeasant * 4 + 1}";
    }

    private void Wave()
    {
        bWarrior -= 4;
        bWheat -= 10;
        bPeasant -= 1;
        warrior.text = $"Воинов: {bWarrior}";
        wheat.text = $"Пшеница: {bWheat}";
        peasant.text = $"Крестьяне: {bPeasant}";

    }

    // Update is called once per frame
    void Update()
    {
        if (Clocks.onActiveWarrior)
        {
            Warrior();
        }
        if (Clocks.onActiveWave)
            Wave();
        if (Clocks.onActiveWheat)
            Wheat();
        if (Clocks.onActivePeasant)
            Peasant();
    }
}
