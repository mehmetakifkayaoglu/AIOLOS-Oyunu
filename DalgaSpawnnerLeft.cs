using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalgaSpawnnerLeft : MonoBehaviour
{
    public GameObject dalga;
    public static int ölenKöylü;
    public GameObject uyarý;
    private float zamanDöngü = 0f;
    private float dalgaDöngü = 0f;
    private float dalgaZamaný = 7f;
    public AudioSource dalgaSesi;
    private Vector3 gercekAcý;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zamanDöngü += Time.deltaTime;
        dalgaDöngü += Time.deltaTime;
        if (zamanDöngü >= 1)
        {

            //yýldýrýmZamaný += yýldýrýmHýzý;
            //yýldýrýmHýzý += yýldýrýmÝvmesi;
            zamanDöngü = 0f;
        }
        if (dalgaDöngü >= dalgaZamaný)
        {
            spawnDalga();
            dalgaZamaný = dalgaZamaný - (dalgaZamaný / 65);
            dalgaDöngü = 0f;
        }
    }
    void spawnDalga()
    {
        Vector3 position = new Vector3(Random.Range(-12.0f, -14.0f), Random.Range(-10.0f, 10.0f), 0);
        if (position.y < -7)
        {
            gercekAcý = new Vector3(0, 0, 300);
        }
        else if (position.y >= -7 && position.y <= 6)
        {
            gercekAcý = new Vector3(0, 0, 270);
        }
        else if (position.y > 6)
        {
            gercekAcý = new Vector3(0, 0, 240);
        }
        var clone = Instantiate(dalga, position, Quaternion.Euler(gercekAcý));
        dalgaSesi.Play();
    }
}
