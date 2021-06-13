using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rüzgar_movement : MonoBehaviour
{
    public GameObject rüzgar;
    public AudioSource wind;
    void Update()
    {

        if (Time.timeScale == 0f)
        {
            rüzgar.SetActive(false);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            rüzgar.SetActive(true);
            wind.Play();
           
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rüzgar.SetActive(false);
            wind.Stop();
        }
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
       rüzgar.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
       
    }
}
