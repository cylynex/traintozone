using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public Level level;

    public void SelectLevel() {
        GameObject background = GameObject.FindGameObjectWithTag("LevelLoadBackgroundImage");
        background.GetComponent<Image>().sprite = level.levelBackgroundImage;

        GameObject levelDetailBox = GameObject.FindGameObjectWithTag("LevelLoadDetails");
        levelDetailBox.SetActive(true);
        Text[] levelDetailText = levelDetailBox.GetComponentsInChildren<Text>();

        levelDetailText[0].text = level.levelName;
        levelDetailText[1].text = level.levelDescription;

        // Setup the button
        //GameObject levelToPlay = GameObject.FindGameObjectWithTag("LevelLoadPlayButton");
        //levelToPlay.GetComponent<LevelPlay>().levelToLoad = level;
        GameManager.instance.currentLevel = level;

    }
}
