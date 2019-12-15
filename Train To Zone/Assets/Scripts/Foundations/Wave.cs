using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wave", menuName = "Levels / Add Wave")]
public class Wave : ScriptableObject {

    public string waveName;
    public Mob[] mobs;

    // Time between each mob spawning
    public float spawnRate;

}
