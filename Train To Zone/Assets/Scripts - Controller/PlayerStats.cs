using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    [Header("Character Attributes")]
    public static int money;
    public static int lives;

    // Player lost a life
    public void SubtractLife() {
        lives--;

        if (lives <= 0) {
            // TODO - make this lose the game here
            lives = 0;
            Debug.Log("YOU HAVE LOST");
            UIManager.Lose();
        }

        UIManager.UpdateLives();
    }

    // Take money (spend on heros or whatever)
    public void TakeMoney(int amount) {
        money -= amount;
        UIManager.UpdateMoney();
    }
}