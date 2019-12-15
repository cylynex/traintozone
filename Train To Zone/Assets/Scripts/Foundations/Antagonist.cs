using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Antagonist", menuName = "Entities / Add Antagonist")]
public class Antagonist : ScriptableObject {

    public string antagonistName;
    public float speed;
    public int hitPoints;
    public GameObject antagonistPrefab;
    public Sprite antagonistImage;

}
