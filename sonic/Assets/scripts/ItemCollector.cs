using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int Coins = 0;
    [SerializeField] private Text ringsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
            Coins++;
            ringsText.text = "RINGS: " + Coins;
        }
    }
}
