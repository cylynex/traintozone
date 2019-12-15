using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    static Text livesText;
    static Text moneyText;
    static Text waveText;

    static GameObject winUI;
    static GameObject loseUI;

    void Awake() {
        livesText = GameObject.FindGameObjectWithTag("uiLives").GetComponent<Text>();
        moneyText = GameObject.FindGameObjectWithTag("uiMoney").GetComponent<Text>();
        waveText = GameObject.FindGameObjectWithTag("uiWave").GetComponent<Text>();

        winUI = GameObject.FindGameObjectWithTag("uiWin");
        winUI.SetActive(false);

        loseUI = GameObject.FindGameObjectWithTag("uiLose");
        loseUI.SetActive(false);


    }


    // Update lives UI
    public static void UpdateLives() {
        livesText.text = PlayerStats.lives.ToString();
    }


    // Update Money UI
    public static void UpdateMoney() {
        Debug.Log("setting money to : " + PlayerStats.money);
        moneyText.text = PlayerStats.money.ToString();
    }


    // Update Wave
    public static void UpdateWave(int currentWave) {
        waveText.text = currentWave.ToString();
    }


    // Win Screen
    public static void Win() {
        winUI.SetActive(true);
    }


    // Show the lose screen
    public static void Lose() {
        loseUI.SetActive(true);
    }


}
