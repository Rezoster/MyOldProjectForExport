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
    public Text numberWave;

    public static int numWave;
    public static int bWarrior;
    public static int bWave;
    public static int bWheat;
    public static int bPeasant;
    private static int saveWarrior;

    public AudioSource audioWin;
    public AudioSource audioLose;

    public static bool boolLose;

    public Button buttonWarrior;
    public Button buttonPeasant;

    public static bool boolButWar;
    public static bool boolButPeas;

    private static bool Result = false;

    // Start is called before the first frame update
    void Start()
    {
        boolButWar = false;
        boolButPeas = false;
    }

    public void TheEnd()
    {
        numWave = 0;
        bWarrior = 0;
        bWave = 0;
        bWheat = 0;
        bPeasant = 0;
        saveWarrior = 0;
        Clocks.currentTimeWave = 0;
        Clocks.currentTimeWheat = 0; 
        Clocks.currentTimeEating = 0;
        Clocks.currentTimePeasant = 0;
        Clocks.currentTimeWarrior = 0;
        Result = false;
        Pause();
}

    public static void Wheat()
    {
        bWheat += 10 + bPeasant;
    }

    public static void UpperNull()
    {
        if(bPeasant < 0)
            bPeasant = 0;
        if(bWarrior < 0)
            bWarrior = 0;
        if(bWheat < 0)
            bWheat = 0;  
        if (bWave < 0) 
            bWave = 0;
    }

    public void Pause()
    {
        if (Time.timeScale != 0)
            Time.timeScale = 0;
        else Time.timeScale = 1;
    }

    public static void Eating()
    {
        bWheat -= (bWarrior * 2 + bPeasant);
        UpperNull();
    }

    private void Text()
    {
        numberWave.text = $"Номер волны: {numWave}";
        wave.text = $"Врагов: {bWave}";
        warrior.text = $"Воинов: {bWarrior}";
        wheat.text = $"Пшеница: {bWheat}";
        peasant.text = $"Крестьяне: {bPeasant}";
    }

    private void CheckWins()
    {
        if((bWave == 0) && (bWheat >= 200) && (bPeasant > 0) && (numWave >= 4) && (numWave >= 10))
        {
            GameObject.Find("ImageBackground").SetActive(false);
            GameObject.Find("ImageLose").SetActive(false);
            audioWin.Play();
            Pause();
            Result = true;
        }
    }

    public void CheckLose()
    {
        if ((bPeasant == 0) && (bWheat == 0) && (bWave > bWarrior) || (bWave > bWarrior && boolLose))
        {
            GameObject.Find("ImageBackground").SetActive(false);
            audioLose.Play();
            Pause();
            Result = true;
        }
    }

    public static void Wave()
    {
        saveWarrior = bWarrior;
        bWarrior -= bWave;
        bWave -= saveWarrior;
        bWheat -= bWave * 3;
        bPeasant -= bWave * 2;
        UpperNull();
    }

    public void ButtonWarrior()
    {
        boolButWar = false;
        bWheat -= 2;
        bWarrior++;
        Clocks.onActiveWarrior = true;
        UpperNull();
    }

    public void ButtonPeasant()
    {
        boolButPeas = false;
        bWheat -= 4;
        bPeasant++;
        Clocks.onActivePheasant = true;
        UpperNull();
    }

    // Update is called once per frame
    void Update()
    {
        if ((numWave == 10 && bWarrior > bWave))
        {
            bWarrior -= bWave;
            bWave = 0;
        }
        else CheckLose();
        numberWave.text = $"Номер Волны: {numWave}";
        buttonPeasant.interactable = boolButPeas;
        buttonWarrior.interactable = boolButWar;
        Text();
        if (!Result)
        {
            CheckLose();
            CheckWins();
        }
    }
 }
