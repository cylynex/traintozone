using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour {

    public static int enemiesAlive = 0;

    public Level boardLevel;

    // Time to spawn first wave
    public float countdown = 3f;

    // Setup for mob spawning and shit
    public Transform spawnPoint;
    //public Transform mobParent;

    // Waves stuff from LEVEL
    public Wave[] waves;
    public int waveIndex = 0;
    public int totalWaves;
    public int currentWave = 0;
    public int mobsInThisWave = 0;

    public Text countdownTimerLabel;

    GameObject trainingAss;
    public static bool antagonistSurvived = false;


    void Start() {

        // Get the level data from the GM
        boardLevel = GameManager.instance.currentLevel;

        // Set the waves to local because it's just easier for right now
        waves = boardLevel.waves;

        waveIndex = 0;
        totalWaves = waves.Length;
        currentWave = 0;
        mobsInThisWave = 0;

        PlayerStats.money = boardLevel.startMoney;
        PlayerStats.lives = boardLevel.startLives;
        //UIManager.UpdateMoney();
        //UIManager.UpdateLives();

        // Get the antagonist rolling first
        //SpawnAntagonist();
    }

    void Update() {
        //Debug.Log("enemies left alive: " + enemiesAlive);
        //Debug.Log("current wave: " + currentWave + " - total waves: " + totalWaves);

        if (countdown <= 0) {

            if (currentWave == totalWaves) {
                countdown = 0;
                // done with waves, if enemies are all dead win.
                if (mobsInThisWave == 0 && enemiesAlive == 0) {
                    //UIManager.Win();
                    //DespawnAntagonist();
                }
            } else {
                // only spawn if we have another level to go to
                countdown = boardLevel.timeBetweenWaves;
                StartCoroutine(SpawnWave());
                return;
            }
        }

        countdown -= Time.deltaTime;

        // TODO Fix for UI stuff
        //countdownTimerLabel.text = string.Format("{0:00.00}", countdown);
    }


    // Start next wave
    IEnumerator SpawnWave() {

        currentWave++;

        //UIManager.UpdateWave(currentWave);

        Wave wave = waves[waveIndex];
        mobsInThisWave = wave.mobs.Length;
        Debug.Log("mobs in this wave: " + mobsInThisWave);

        for (int i = 0; i < mobsInThisWave; i++) {
            Debug.Log("spawn loop " + i);
            SpawnMob(wave.mobs[i]);
            mobsInThisWave--;
            yield return new WaitForSeconds(wave.spawnRate);
        }

        waveIndex++;

    }


    // Spawn mob
    void SpawnMob(Mob mobObject) {
        Debug.Log("SPAWNING A MOB");
        GameObject thisMob = Instantiate(mobObject.mobPrefab, spawnPoint.position, spawnPoint.rotation);
        thisMob.transform.SetParent(transform, true);

        // Add the object so mob has all the info it needs to exist
        thisMob.GetComponent<MobController>().mob = mobObject;

        // Add to enemies alive for tracking
        enemiesAlive++;
    }


    // Spawn the antagonist // TODO allow for multiple antagonists.  Its an array but just uses 1 now.
    void SpawnAntagonist() {
        GameObject antagonistPrefab = boardLevel.antagonists[0].antagonistPrefab;
        trainingAss = Instantiate(antagonistPrefab, spawnPoint.position, spawnPoint.rotation);
        trainingAss.transform.SetParent(transform, true);

    }


    // Despawn antagonist when level is over if he still is alive
    void DespawnAntagonist() {
        if (trainingAss != null) {
            antagonistSurvived = true;
            Destroy(trainingAss);
        }
    }
}
