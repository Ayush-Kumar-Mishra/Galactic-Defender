using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    float inputX, inputZ;
    public GameObject spawnPoint;
    public GameObject gameOverImage;
    public TMP_Text desScoreText;
    public AudioSource bgmSource;
    public AudioSource accSource;

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        float posX = transform.position.x + inputX * speed;
        transform.position = new Vector3(Mathf.Clamp(posX,-30f,30f), transform.position.y + 0 , transform.position.z + 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            spawnPoint.SetActive(false);
            Destroy(this.gameObject,1f);
            bgmSource.Pause();
            accSource.Pause();
            gameOverImage.gameObject.SetActive(true);
        }
    }
}
