using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject gameOverText;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger");
        if (collision.tag == "Player")
        {
            gameOverText.SetActive(true);
            audioSource.Play();
            Debug.Log("Player has touched the Obstacle!");
        }
    }
}
