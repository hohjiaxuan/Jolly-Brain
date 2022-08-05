using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;
    private int water = 0;
    private int score = 0;

    [SerializeField] private Text coinsCount;
    [SerializeField] private Text waterCount;
    [SerializeField] private Text scoreCount;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            //collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            coinsCount.text = ": " + coins;
            score += 10;
            scoreCount.text = "Score: " + score;
        }

        if (collision.gameObject.CompareTag("Water"))
        {
            //collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            water++;
            waterCount.text = ": " + water;
            score +=5;
            scoreCount.text = "Score: " + score;
        }
    }
}
