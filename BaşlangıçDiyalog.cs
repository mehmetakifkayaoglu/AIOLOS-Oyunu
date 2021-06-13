using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaşlangıçDiyalog : MonoBehaviour
{
    private Animator başlangıçDiyalogAnimator;
    private float diyalogSayaç;

    private void Start()
    {
        başlangıçDiyalogAnimator = GetComponent<Animator>();
        diyalogSayaç = 0;
        başlangıçDiyalogAnimator.SetFloat("diyalogKontrol", 0);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && diyalogSayaç < 6.5f)
        {
            diyalogSayaç += 1;
            başlangıçDiyalogAnimator.SetFloat("diyalogKontrol", diyalogSayaç);
        }
        if(diyalogSayaç < 6.5)
        {
            Time.timeScale = 0f;
        }else if (diyalogSayaç > 6.5f)
        {
            Time.timeScale = 1f;
        }
    }
}
