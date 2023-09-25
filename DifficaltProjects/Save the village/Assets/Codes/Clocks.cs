using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clocks : MonoBehaviour
{
    public float maxTimeWarrior;
    public float maxTimeWave;
    public float maxTimeWheat;
    public float maxTimePeasant;

    public Image imgWarrior;
    public Image imgWave;
    public Image imgWheat;
    public Image imgPeasant;

    private float currentTimeWarrior;
    private float currentTimeWave;
    private float currentTimeWheat;
    private float currentTimePeasant;

    public static bool onActiveWarrior = false;
    public static bool onActiveWave = false;
    public static bool onActiveWheat = false;
    public static bool onActivePeasant = false;

    void Start()
    {
        currentTimeWarrior = maxTimeWarrior;
        currentTimeWave = maxTimeWave;
        currentTimeWheat = maxTimeWheat;
        currentTimePeasant = maxTimePeasant;
    }

    private void CurrentWarrior()
    {
        currentTimeWarrior -= Time.deltaTime;
        if (currentTimeWarrior <= 0)
        {
            currentTimeWarrior = maxTimeWarrior;
            onActiveWarrior = true;
        }
        onActiveWarrior = false;


    }

    private void CurrentWave()
    {
        currentTimeWave -= Time.deltaTime;
        if (currentTimeWave <= 0)
        {
            onActiveWave = true;
            currentTimeWave = maxTimeWave;
        }
        onActiveWave = false;
    }

    private void CurrentWheat()
    {
        currentTimeWheat -= Time.deltaTime;
        if ( currentTimeWheat <= 0)
        {
            currentTimeWheat = maxTimeWheat;
            onActiveWheat = true;
        }
        onActiveWheat = false;

    }

    private void CurrentPeasant()
    {
        currentTimePeasant -= Time.deltaTime;
        if (currentTimePeasant <= 0)
        {
            onActivePeasant = true;
            currentTimePeasant = maxTimePeasant;
        }
        onActivePeasant = false;
    }



    // Update is called once per frame
    void Update()
    {
        imgPeasant.fillAmount = currentTimePeasant / maxTimePeasant;
        imgWarrior.fillAmount = currentTimeWarrior / maxTimeWarrior;
        imgWheat.fillAmount = currentTimeWheat / maxTimeWheat;
        imgWave.fillAmount = currentTimeWave / maxTimeWave;

        CurrentWarrior();
        CurrentWave();
        CurrentPeasant();
        CurrentWheat();

        
}
}
