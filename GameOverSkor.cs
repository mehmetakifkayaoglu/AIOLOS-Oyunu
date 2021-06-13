using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverSkor : MonoBehaviour
{
    private TextMeshProUGUI scorTextGameOver;
    public GameObject skorGameObject;
    void Start()
    {
        scorTextGameOver = skorGameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scorTextGameOver.text = healthbar.puan.ToString();
    }
}
