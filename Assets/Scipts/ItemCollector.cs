using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int itemCount = 0;

    public TextMeshProUGUI countText;
    public AudioSource itemCollect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("melon"))
        {
            //if the player collides with a melon destroy the melon and incremenet the count of how many have been collected
            Destroy(collision.gameObject);
            itemCount++;
            countText.text = "Melons: " + itemCount;
            itemCollect.Play();
        }
    }
}
