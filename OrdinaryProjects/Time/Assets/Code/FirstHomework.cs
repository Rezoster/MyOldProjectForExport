using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstHomework : MonoBehaviour
{
    public Text allRound;
    public Text oneRound;
    public Text numberOfLap;
    private float currentTime;
    private float currentNewTime;
    private short nRound = 0;
    private short nOneRound = 0;

    public Button button;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Round(7.7f));
        Debug.Log(Mathf.Round(1.4f));
        Debug.Log(Mathf.Round(3.8f));
        Debug.Log(Mathf.Round(9.9f));
    }

    public void OnClick()
    {
        oneRound.text = nOneRound.ToString();
        currentTime = Mathf.Round(Time.time);
        nRound++;
        numberOfLap.text = nRound.ToString();
    }



    // Update is called once per frame
    void Update()
    {
        currentNewTime = Mathf.Round(Time.time) - currentTime;
        allRound.text = Mathf.Round(Time.time).ToString();
        oneRound.text = currentNewTime.ToString();
    }
}
