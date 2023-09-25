using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Crack : MonoBehaviour
{
    public GameObject Codes;
    public Text firstPinRes;
    public Text secondPinRes;
    public Text thirdPinRes;
    public Text firstPinInput;
    public Text secondPinInput;
    public Text thirdPinInput;
    public Text timer;
    private short cfirstPinInput;    
    private short csecondPinInput;
    private short cthirdPinInput;
    private float currentTime;




    // Start is called before the first frame update
    void Start()
    {
        firstPinRes.text = "3";
        secondPinRes.text = "5";
        thirdPinRes.text = "4";
        SetDisactivateScript();
    }

    private void Fin()
    {
        if ((firstPinInput.text == firstPinRes.text) && (secondPinInput.text == secondPinRes.text) && (thirdPinInput.text == thirdPinRes.text))
        {
            GameObject.Find("CrackALock").SetActive(false);
            GameObject.Find("ImagePreAnotherHistory").SetActive(false);
            SetDisactivateScript();

        }
        if (currentTime <= 0)
        {
            GameObject.Find("CrackALock").SetActive(false);
            GameObject.Find("ImagePreSecHistory").SetActive(false);
            SetDisactivateScript();
        }
        
    }

    public void SetDisactivateScript()
    {
        cfirstPinInput = 0;
        csecondPinInput = 0;
        cthirdPinInput = 0;
        Codes.SetActive(false);
    }

    public void SetActivateScript()
    {
        cfirstPinInput = 0;
        csecondPinInput = 0;
        cthirdPinInput = 0;
        Codes.SetActive(true);
    }

    public void UsingHammer()
    {
        firstPinInput.text = (cfirstPinInput++).ToString();
        secondPinInput.text = (csecondPinInput--).ToString();
        thirdPinInput.text = (cthirdPinInput++).ToString();
        Fin();
    }

    public void UsingDrill()
    {
        firstPinInput.text = (cfirstPinInput++).ToString();
        thirdPinInput.text = (cthirdPinInput--).ToString();
        Fin();
    }

    public void UsingMasterKey()
    {
        firstPinInput.text = (cfirstPinInput--).ToString();
        secondPinInput.text = (csecondPinInput++).ToString();
        Fin();
    }

    public void UsingHairpin()
    {
        secondPinInput.text = (csecondPinInput++).ToString();
        Fin();
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime = 130 - Mathf.Round(Time.time);
        if ((firstPinInput.text == firstPinRes.text) && (secondPinInput.text == secondPinRes.text) && (thirdPinInput.text == thirdPinRes.text))
        {

            timer.text = timer.text;
            return;
        }
        if (currentTime < 0)
        {
            currentTime = 0;
            return;
        }

        timer.text = currentTime.ToString();
    }
}

