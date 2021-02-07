using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resDropdown;
    Resolution[] res;

    private void Start()
    {
        res = Screen.resolutions;
        resDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResIndex = 0;
        for (int i = 0; i < res.Length; i++)
        {
            string option = res[i].width + "x" + res[i].height;
            options.Add(option);

            if(res[i].width == Screen.currentResolution.width && res[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = currentResIndex;
        resDropdown.RefreshShownValue();
    }

    public void SetResolution(int resIndex)
    {
        Resolution resolution = res[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MixerVolume", volume);
    }
    
    public void SetGraphic(int qIndex)
    {
        QualitySettings.SetQualityLevel(qIndex);
    }

    public void FullscreenToggle(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
