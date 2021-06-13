using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalgaYokEtme : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "dalga")
        {
            Destroy(collision.gameObject);
        }
    }
}
