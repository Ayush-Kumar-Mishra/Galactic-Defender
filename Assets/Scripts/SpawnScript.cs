using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnScript : MonoBehaviour
{

    float timer;
    public GameObject[] enemies;


    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 3)
        {
            var RandomSpawn = Random.Range(0, enemies.Length);
            var Clone = Instantiate(enemies[RandomSpawn], transform.position, enemies[RandomSpawn].transform.rotation);
            Destroy(Clone, 5f);
            timer = 0;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        ScoreScript.score = 0;
    }
}
