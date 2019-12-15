using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Level", menuName = "Levels / Add Level")]
public class Level : ScriptableObject {

    [Header("Level Setup Stuff")]
    public int startMoney;
    public int startLives;
    public string levelName;
    public Sprite levelBackgroundImage;
    public GameObject mapGrid;

    [TextArea(5,5)]
    public string levelDescription;

    [Header("Enemies")]
    public Wave[] waves;
    public Antagonist[] antagonists;
    public float timeBetweenWaves;

}
