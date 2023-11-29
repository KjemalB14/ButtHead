using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeAndDeath : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidBody;

    public AudioSource deathEffect;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when the player hits the spikes the player will die
        if (collision.gameObject.CompareTag("spikes"))
        {
            PlayerDies();
        }
    }

    //this function handles the player death
    private void PlayerDies()
    {
        animator.SetTrigger("Death");
        rigidBody.bodyType = RigidbodyType2D.Static;
        deathEffect.Play();
    }

    private void LevelReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
