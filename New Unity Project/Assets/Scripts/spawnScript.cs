using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        //check to see if player is the Collider entering the space
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
