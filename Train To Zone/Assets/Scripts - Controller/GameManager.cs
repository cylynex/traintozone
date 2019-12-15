using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Level currentLevel;

    public static GameManager instance;

    // Load the GM as a singleton
    void Awake() {
        if (instance != null) { 
            Debug.Log("multiple GM found"); 
            return; 
        } else { 
            instance = this; 
            Debug.Log("GameManager Loaded");
        }

    }
}
