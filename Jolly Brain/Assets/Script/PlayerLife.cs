using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private Vector3 respawnPoint;

    [Header("Life Count")]
    public Image[] life;
    public int livesRemaining;

    [Header("Game Over")]
    public GameObject gameoverLabel;
    public GameObject button;

    [SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        respawnPoint = transform.position;
    }

    public void LoseLife()
    {
        if (livesRemaining == 0)
            return;

        livesRemaining--;
        life[livesRemaining].enabled = false;

        if (livesRemaining == 0)
        {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            respawnPoint = transform.position;
            FindObjectOfType<NPC>().TriggerDialogue();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            LoseLife();
            StartCoroutine("Die");
            StartCoroutine("Respawn");
        }

        if(collision.gameObject.CompareTag("Enemy") && livesRemaining > 0)
        {
             LoseLife();
            StartCoroutine("Die");
            StartCoroutine("Respawn");
        }
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.75f);
        transform.position = respawnPoint;
    }

    private void Die()
    {
        /*deathSoundEffect.Play();*/
        anim.SetTrigger("death");
    }

    /*private void Hit()
    {
        *//*deathSoundEffect.Play();*//*
        anim.SetTrigger("hit");
    }*/

    void GameOver()
    {
        gameoverLabel.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    /*private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
