using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class SpawnLightning : MonoBehaviour
{
    public static float ölenKöylü =0f;
    public GameObject Lightning;
    public GameObject uyarý;
    public AudioSource lightingSound;
    private bool uyarýControl;
    private float yýldýrýmDöngü = 0f;
    //private float yýldýrýmÝvmesi = 0.2f;
    //private float yýldýrýmHýzý = 0f;
    private float yýldýrýmZamaný = 3f;

    private void Start()
    {
        ölenKöylü = 0;
    }


    void Update()
    {
        yýldýrýmDöngü += Time.deltaTime;

        if (yýldýrýmDöngü >= yýldýrýmZamaný)
        {
            StartCoroutine(spawnLightning());
            if (yýldýrýmZamaný>0.4f)
            { 
                yýldýrýmZamaný = yýldýrýmZamaný - (yýldýrýmZamaný /50);
            }
            yýldýrýmDöngü = 0f;
        }
        /*
        timeLeft -= 1;
        if (timeLeft % 1000 == 0)
        {
            StartCoroutine(spawnLightning());
        }
        */
    }
    public IEnumerator spawnLightning()
    {
        Vector3 position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), 0);
        var clone = Instantiate(Lightning, position, Quaternion.identity);
        clone.SetActive(false);
        var uyarýClone = Instantiate(uyarý, clone.transform.position, Quaternion.identity);
        uyarýControl = true;
        Object.Destroy(uyarýClone, 3.0f);
        yield return new WaitForSeconds(3);
        uyarýControl = false;
        if(uyarýControl == false)
        {
            lightingSound.Play();
            clone.SetActive(true);
        }
        Object.Destroy(clone, 0.2f);
    }
}
