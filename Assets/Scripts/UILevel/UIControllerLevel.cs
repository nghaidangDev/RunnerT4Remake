using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControllerLevel : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public Image fillmusic, fillsfx;

    private void Start()
    {
        float fillMusic = PlayerPrefs.GetFloat("Mucsic Slider", 1f);
        float fillSFX = PlayerPrefs.GetFloat("SFX Slider", 1f);

        fillmusic.fillAmount = fillMusic;
        fillsfx.fillAmount = fillSFX;

        _musicSlider.value = fillMusic;
        _sfxSlider.value = fillSFX;

        _musicSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        _sfxSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }


    public void MusicVolume()
    {
        AudioManager.instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(_sfxSlider.value);
    }

    private void ValueChangeCheck()
    {
        float musicSlider = _musicSlider.value;
        float sfxSlider = _sfxSlider.value;

        // Thay đổi fill area
        fillmusic.fillAmount = musicSlider;
        fillsfx.fillAmount = sfxSlider;

        PlayerPrefs.SetFloat("Mucsic Slider", _musicSlider.value);
        PlayerPrefs.SetFloat("SFX Slider", _sfxSlider.value);
        PlayerPrefs.Save();
    }
}
