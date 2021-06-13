using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    private void Start()
    {
        //pausePanel.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }
    public void Retrun()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
