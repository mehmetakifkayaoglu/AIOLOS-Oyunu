using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerAI : MonoBehaviour
{
    private float enSonYönDeðiþtirmeZamaný;
    private Rigidbody2D rb2d;
    private float yönDeðiþtirmeZamaný;
    private float karakterHýz = 2f;
    private Vector2 hareketYönü;
    private Vector2 saniyedehareket ;

    private Vector2 ItmeVektoru;
    private Vector3 ItmeYonu;
    private float ýtmeGucu = 6f;
    private float mesafe;
    private bool etkiSýnýrýndaMý = false;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        yönDeðiþtirmeZamaný = Random.Range(3f, 4f);
        enSonYönDeðiþtirmeZamaný = 0f;
        calcuateNewMovementVector();
    }


    void Update()
    {
        if (Time.time - enSonYönDeðiþtirmeZamaný > yönDeðiþtirmeZamaný)
        {
            enSonYönDeðiþtirmeZamaný = Time.time;
            yönDeðiþtirmeZamaný = Random.Range(2f, 3f);
            calcuateNewMovementVector();
        }

        if (Input.GetMouseButton(0) && etkiSýnýrýndaMý)
        {
            rb2d.AddForce(ItmeVektoru * ýtmeGucu * Time.deltaTime , ForceMode2D.Impulse);
        }else
        {
            transform.position = new Vector2(transform.position.x + (saniyedehareket.x * Time.deltaTime),
            transform.position.y + (saniyedehareket.y * Time.deltaTime));
            if ( saniyedehareket.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (saniyedehareket.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "ruzgar")
        {
            ItmeYonu = transform.position - collision.transform.position;
            mesafe = Mathf.Sqrt(ItmeYonu.x * ItmeYonu.x + ItmeYonu.y * ItmeYonu.y);
            ItmeVektoru = new Vector2(ItmeYonu.x / mesafe, ItmeYonu.y / mesafe);
            etkiSýnýrýndaMý = true;
        }
        if (collision.tag == "sahil")
        {
            SpawnLightning.ölenKöylü += 1;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ruzgar")
        {
            etkiSýnýrýndaMý = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dalga")
        {
            SpawnLightning.ölenKöylü += 1;
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="yýldýrým")
        {
            SpawnLightning.ölenKöylü += 1;
           // Debug.Log(SpawnLightning.ölenKöylü);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "kuzey")
        {
            YukarýCarpmaVektor();
        }
        else if (collision.gameObject.tag == "güney")
        {
            AssagýCarpmaVektor();
        }
        else if (collision.gameObject.tag == "batý")
        {
            SolaCarpmaVektor();
        }
        else if (collision.gameObject.tag == "doðu")
        {
            SagaCarpmaVektor();
        }
        else
        {
            calcuateNewMovementVector();
        }
    }
    void calcuateNewMovementVector()
    {
        hareketYönü = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        saniyedehareket = hareketYönü * karakterHýz;
    }
    
    void SagaCarpmaVektor()
    {
        hareketYönü = new Vector2(Random.Range(-1.0f, 0f), Random.Range(-1.0f, 1.0f)).normalized;
        saniyedehareket = hareketYönü * karakterHýz;
    }
    void SolaCarpmaVektor()
    {
        hareketYönü = new Vector2(Random.Range(0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        saniyedehareket = hareketYönü * karakterHýz;
    }
    void AssagýCarpmaVektor()
    {
        hareketYönü = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(0f, 1.0f)).normalized;
        saniyedehareket = hareketYönü * karakterHýz;
    }
    void YukarýCarpmaVektor()
    {
        hareketYönü = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 0f)).normalized;
        saniyedehareket = hareketYönü * karakterHýz;
    }
}
