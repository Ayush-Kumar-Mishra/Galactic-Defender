using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Spawn_Script : MonoBehaviour
{

    public GameObject missilePrefab;
    public AudioSource shootSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var misClone = Instantiate(missilePrefab, transform.position, missilePrefab.transform.rotation);
            Destroy(misClone, 5f);
            shootSource.Play();
        }
    }
}
