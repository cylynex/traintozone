using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mob", menuName = "Entities / Add Mob")]
public class Mob : ScriptableObject {

    [Header("Basics")]
    public string mobName;
    public Sprite mobImage;

    [Header("Defensive")]
    public int startHitPoints;

    [Header("Character")]
    public float startSpeed;
    public int moneyGain;
    public GameObject deathEffect;
    public GameObject mobPrefab;

    [Header("Offensive")]
    public float range;
    public float fireRate;
    public float damage;
    public float antagonistRange;
}
