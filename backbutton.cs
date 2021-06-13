using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class backbutton : MonoBehaviour
{
  

   private void Update()
    {
        if (SpawnLightning.ölenKöylü == 20)
        {
            SceneManager.LoadScene("gameover");
            SpawnLightning.ölenKöylü = 21;

        }
        Debug.Log(SpawnLightning.ölenKöylü);
    }

    public  void back()
    {
        SceneManager.LoadScene("anamenü");
    }
    public void setttings()
    {
        SceneManager.LoadScene("settingsmenü");
    }
    public void play()
    {
        SceneManager.LoadScene("Oyun");
      
    }
    public void credits()
    {
        SceneManager.LoadScene("credits");
    }
    public AudioMixer AudioMixer;
    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("volume", volume);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
