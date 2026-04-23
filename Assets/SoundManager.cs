using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Text sound = null;
    private bool muted = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else 
        {
            Load();
        }

        UpdateButtonText();
        AudioListener.pause = muted;
    }

    public void OnButtonPress() 
    {
        if(muted == false) 
        {
            muted = true;
            AudioListener.pause = true;
        }
        else 
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonText();
    }

    private void UpdateButtonText() 
    {
        if(muted == false)
        {
            sound.text = "Music: ON";
        }
        else 
        {
            sound.text = "Music: OFF";
        }
    }

    private void Load() 
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
