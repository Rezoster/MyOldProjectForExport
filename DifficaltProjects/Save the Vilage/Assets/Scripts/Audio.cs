using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    private AudioSource audioWave;
    private AudioSource audioWheat;
    private AudioSource audioWin;
    private AudioSource audioLose;

    // Start is called before the first frame update
    void Start()
    {
        audioWave = GetComponent<AudioSource>();
        audioWave.Play();
        audioWheat = GetComponent<AudioSource>();
        audioWheat.Play();
        audioWin = GetComponent<AudioSource>();
        audioWin.Play();
        audioLose = GetComponent<AudioSource>();
        audioLose.Play();
    }
    
    public void PlayWarrior()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
