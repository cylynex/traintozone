using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {

    //PlayerStats playerstats;

    void Start() {
        //playerstats = GameObject.FindObjectOfType<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);

        // Subtract a life
        //playerstats.SubtractLife();

        // Subtract from the enemies left alive counter as well
        //WaveSpawner.enemiesAlive--;

    }
}
