using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    public GameObject audioOn;
    public GameObject audioOff;
    public GameObject audioSource;
    private bool isAudioOn;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        audioOn.SetActive(true);
        audioOff.SetActive(false);
        audioSource.SetActive(false);
        isAudioOn = false;

    }

    private void OnMouseDown()
    {
        if (isAudioOn)
        {
            audioOn.SetActive(true);
            audioOff.SetActive(false);
            audioSource.SetActive(false);
            isAudioOn = false;
        } else
        {
            audioOn.SetActive(false);
            audioOff.SetActive(true);
            audioSource.SetActive(true);
            isAudioOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
