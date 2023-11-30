using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompletion = false;

    // Start is called before the first frame update
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Once the player reaches the flag a sound effect is played and there is a 2 second delay before the next Scene loads
        if (collision.gameObject.CompareTag("Player") && !levelCompletion) 
        {
            finishSound.Play();
            levelCompletion = true;
            Invoke("LoadNextLevel", 2f);
        }
    }

    //Loads the next Scene
    private void LoadNextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

