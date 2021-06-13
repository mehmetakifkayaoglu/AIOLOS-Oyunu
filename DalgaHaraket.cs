using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalgaHaraket : MonoBehaviour
{
    private float speed = 4.0f;
    private Vector2 target;
    private Vector2 position;
    private Animator dalgaAnimator;
    void Start()
    {
        dalgaAnimator = GetComponent<Animator>();
        dalgaAnimator.SetBool("denizdeMi", false);
        dalgaAnimator.SetBool("sahildeMi", false);
        target = new Vector2(0.0f, 0.0f);
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        Debug.Log("sahil carpýþma gercekleþti");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "denizSýnýrý")
        {
            dalgaAnimator.SetBool("denizdeMi", true);
        }
        if(collision.tag == "sahil")
        {
            dalgaAnimator.SetBool("sahildeMi", true);
        }
    }
}
