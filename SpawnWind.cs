using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpawnWind : MonoBehaviour
{
    public GameObject Prefab;

    private void Start()
    {
        Prefab.SetActive(false); 
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Prefab.transform.position = mousePos;
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Prefab.SetActive(true);
        //    Vector3 mousePos = Input.mousePosition;
        //    mousePos.z = 10;
        //    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //    Instantiate(Prefab, worldPosition, Quaternion.identity);
           
            
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Prefab.SetActive(false);
        //}
    }
}
