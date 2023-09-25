using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clocks : MonoBehaviour
{
    public float maxTimeWave;
    public float maxTimeWheat;
    public float maxTimeEating;
    public float maxTimePeasant;
    public float maxTimeWarrior;

    public Image imgWave;
    public Image imgWheat;
    public Image imgEating;
    public Image imgPeasant;
    public Image imgWarrior;

    public AudioSource audioWave;
    public AudioSource audioWheat;

    public static float currentTimeWave;
    public static float currentTimeWheat;
    public static float currentTimeEating;
    public static float currentTimePeasant;
    public static float currentTimeWarrior;

    public static bool onActiveWarrior = false;
    public static bool onActivePheasant = false;

    void Start()
    {
        currentTimeWave = maxTimeWave;
        currentTimeWheat = maxTimeWheat;
        currentTimeEating = maxTimeEating;
        currentTimePeasant = maxTimePeasant;
        currentTimeWarrior = maxTimeWarrior;


        
    }

    private void LevelCheck()
    {
        if ((onActiveWarrior && (Indicator.bWave == 0) && onActivePheasant) || ((Indicator.numWave == 4 ) && (Indicator.bWave == 0)))
        {
            if (Indicator.numWave > 3 && Indicator.numWave < 10) 
                if (Indicator.numWave == 4)
                    Indicator.bWave = Indicator.numWave;
                else Indicator.bWave += (4 + Indicator.bWave++);
           /* currentTimeWave = 1;
            currentTimeWheat = 1;
            currentTimePeasant = 1;
            currentTimeWarrior = 1; */
            onActiveWarrior = false;
            onActivePheasant = false; 
            Indicator.numWave++;
        }
    }

    private void CurrentWarriror()
    {
        currentTimeWarrior -= Time.deltaTime;
        if(currentTimeWarrior <= 0 && Indicator.bWheat >= 4)
        {
            currentTimeWarrior = maxTimeWarrior;
            Indicator.boolButWar = true;
        }
    }

     private void CurrentPeasant()
    {
        currentTimePeasant -= Time.deltaTime;
        if( currentTimePeasant <= 0 && Indicator.bWheat >= 2)
        {
            currentTimePeasant = maxTimePeasant;
            Indicator.boolButPeas = true;

        }
    }

     private void CurrentWave()
    {
        currentTimeWave -= Time.deltaTime;
        if (currentTimeWave <= 0)
        {
            audioWave.Play();
            currentTimeWave = maxTimeWave;
            Indicator.boolLose = true;
            Indicator.Wave();
        } else Indicator.boolLose = false;
    }

    private void CurrentWheat()
    {
        currentTimeWheat -= Time.deltaTime;
        if (currentTimeWheat <= 0)
        {
            audioWheat.Play();
            currentTimeWheat = maxTimeWheat;
            Indicator.Wheat();
        }

    }

    private void CurrentEating()
    {
        currentTimeEating -= Time.deltaTime;
        if (currentTimeEating <= 0)
        {
            currentTimeEating = maxTimeEating;
            Indicator.Eating();
        }
    }



    // Update is called once per frame
    void Update() 
    {
        LevelCheck();
        CurrentWarriror();
        CurrentPeasant();
        CurrentWheat();
        CurrentEating();
        imgWheat.fillAmount = currentTimeWheat / maxTimeWheat;
        if (Indicator.numWave > 4 && Indicator.numWave < 10)
        {
            imgWave.fillAmount = currentTimeWave / maxTimeWave;
            CurrentWave();
        }
        else imgWave.fillAmount = 1;
         imgEating.fillAmount = currentTimeEating / maxTimeEating;
        imgWarrior.fillAmount = currentTimeWarrior / maxTimeWarrior;
        imgPeasant.fillAmount = currentTimePeasant / maxTimePeasant;
    }
}