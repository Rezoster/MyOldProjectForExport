using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTimer : MonoBehaviour
{
    public float MaxTime;
    public bool Tick;

    private Image harvestCostTime;
    private Image warriorCostTime;
    private Image nextRaidCostTime;
    private float currentTime;

    void Start()
    {
        harvestCostTime = GetComponent<Image>();
        warriorCostTime = GetComponent<Image>();
        nextRaidCostTime = GetComponent<Image>();
        currentTime = MaxTime;
    }

    void Update()
    {
        HarvestTime();
        WarriorTime();
        NextRaidTime();
    }

    public void HarvestTime()
    {
        Tick = false;
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Tick = true;
            currentTime = MaxTime;
        }

        harvestCostTime.fillAmount = currentTime / MaxTime;
    }

    public void WarriorTime()
    {
        Tick = false;
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Tick = true;
            currentTime = MaxTime;
        }

        warriorCostTime.fillAmount = currentTime / MaxTime;
    }

    public void NextRaidTime()
    {
        Tick = false;
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Tick = true;
            currentTime = MaxTime;
        }

        nextRaidCostTime.fillAmount = currentTime / MaxTime;
    }
}
