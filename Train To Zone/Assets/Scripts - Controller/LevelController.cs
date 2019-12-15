using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public Transform gridHolder;

    void Start() {
        //Debug.Log("loading level" + GameManager.instance.currentLevel.levelName);
        //GameObject thisLevel = (GameObject)Instantiate(GameManager.instance.currentLevel.mapGrid, gridHolder.position, Quaternion.identity);
        //thisLevel.transform.SetParent(gridHolder, false);
    }

}
