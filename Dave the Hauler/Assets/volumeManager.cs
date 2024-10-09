using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeManager : MonoBehaviour
{
    [SerializeField]
    Slider volumeSlider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("bgmVolume"))
        {
            PlayerPrefs.SetFloat("bgmVolume", 1 / 2);
            Load();
        }
        else
        { 
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("bgmVolume");
    }

    private void Save ()
    {
        PlayerPrefs.SetFloat("bgmVolume",  volumeSlider.value);
    }
}
