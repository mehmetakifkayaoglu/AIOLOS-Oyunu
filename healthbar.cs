using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthbar : MonoBehaviour
{
    static float health;
    public Slider slider;
    float puanÇarpaný;
    public static float puan;
    private TextMeshProUGUI scorText;
    public GameObject healtbar;
    private float zaman;

    public void Start()
    {
        zaman = 0f;
        puan = 0f;
        health = slider.maxValue;
        scorText = healtbar.GetComponent<TextMeshProUGUI>();
    }
    public void Update()
    {
        zaman += Time.deltaTime;
        puanÇarpaný = 20 - SpawnLightning.ölenKöylü;
        if (zaman >1f)
        {
            puan += puanÇarpaný * Time.deltaTime;
            zaman = 1;
        }
        slider.value = health - SpawnLightning.ölenKöylü;
        scorText.text = puan.ToString();
       
    }

}
