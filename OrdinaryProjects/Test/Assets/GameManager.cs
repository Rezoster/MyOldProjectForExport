using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ImageTimer HarvestTimer;
    public ImageTimer WarriorTime;
    public Image PeasantTimerImg;
    public Image WarriorTimerImg;
    public Image RaidTimerImg;

    public Button peasantButton;
    public Button warriorButton;
    public Button pauseButton;

    public Button RestartButton;

    public Text peasantText;
    public Text warriorText;
    public Text harvestText;

    public int peasantCount;
    public int warriorCount;
    public int harvestCount;

    public int wheatPerPeasant;
    public int wheatToWarrior;

    public int peasantCost;
    public int warriorCost;

    public float peasantCreateTime;
    public float warriorCreateTime;
    public float raidMaxTime;
    public int raidIncrease;
    public int nextRaid;

    public GameObject GameOverScreen;

    private float peasantTimer = -2;
    private float warriorTimer = -2;
    private float raidTimer;

    void Start()
    {
        UpdateText();    
    }

    void Update()
    {
        raidTimer -= Time.deltaTime;
        RaidTimerImg.fillAmount = raidTimer / raidMaxTime;

        if(raidTimer <= 0)
        {
            raidTimer = raidMaxTime;
            warriorCount -= nextRaid;
            nextRaid += raidIncrease;
        }

        if(HarvestTimer.Tick)
        {
            harvestCount += peasantCount * wheatPerPeasant;
        }

        if(WarriorTime.Tick)
        {
            harvestCount -= warriorCount * wheatToWarrior;
        }

        if(peasantTimer > 0)
        {
            peasantTimer -= Time.deltaTime;
            PeasantTimerImg.fillAmount = peasantTimer / peasantCreateTime;
        }
        else if(peasantTimer > -1)
        {
            PeasantTimerImg.fillAmount = 1;
            peasantButton.interactable = true;
            peasantCount += 1;
            peasantTimer = -2;
        }

        if(warriorTimer > 0)
        {
            warriorTimer -= Time.deltaTime;
            WarriorTimerImg.fillAmount = warriorTimer / warriorCreateTime;
        }
        else if(warriorTimer > -1)
        {
            WarriorTimerImg.fillAmount = 1;
            warriorButton.interactable = true;
            warriorCount += 1;
            warriorTimer = -2;
        }

        UpdateText();

        if(warriorCount < 0)
        {
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
        }
    }

    private void UpdateText()
    {
        peasantText.text = peasantCount.ToString();
        warriorText.text = warriorCount.ToString();
        harvestText.text = harvestCount.ToString();
    }

    public void CreatePeasant()
    {
        harvestCount -= peasantCost;
        peasantTimer = peasantCreateTime;
        peasantButton.interactable = false;
    }

    public void CreateWarrior()
    { 
        harvestCount -= warriorCost;
        warriorTimer = warriorCreateTime;
        warriorButton.interactable = false;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
