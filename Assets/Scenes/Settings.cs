using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;


public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TMP_Dropdown resDropdown;
    Resolution[] res;
<<<<<<< HEAD
    public float mouseSen;
    public Slider VolumeSlider;
=======
    public static float camSen;
    public static float fov;
>>>>>>> Lawrence's-Branch

    private void Start()
    {
        camSen = 400f;
        fov = 60f;
        res = Screen.resolutions;
        resDropdown.ClearOptions();
        VolumeSlider.value = PlayerPrefs.GetFloat("GameVolume", 1f);

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
        audioMixer.SetFloat("MixerVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("GameVolume", volume);
    }
    
    public void SetGraphic(int qIndex)
    {
        QualitySettings.SetQualityLevel(qIndex);
    }

    public void FullscreenToggle(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetSensitivity(float sens)
    {
        camSen = sens;
    }

    public void SetFOV(float fieldOfView)
    {
        fov = fieldOfView;
    }
}
