using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour {

    public void LoadLevel(string levelToLoad) {
        SceneManager.LoadScene(levelToLoad);
    }


    public void ReloadCurrentLevel() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


}
