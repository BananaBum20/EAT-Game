using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// detect when the ball touches the goal, and then win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;

    private AudioSource audioSource;

    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger");
        if (collision.tag == "Player" && !GameOver.IsGameOver)
        {
            winText.SetActive(true);
            audioSource.Play();
            Debug.Log("The player has entered the goal.");
            Time.timeScale = 0.0f;
            
        }

    }
}
