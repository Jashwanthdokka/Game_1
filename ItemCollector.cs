using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int stars = 0;

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.CompareTag("star"))
        {
            Destroy(collision.gameObject);
            stars++;
        }
   }
}


