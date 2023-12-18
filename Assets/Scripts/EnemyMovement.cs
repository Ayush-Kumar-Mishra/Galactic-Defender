using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    public MeshRenderer mr;
    public ParticleSystem explosion;
    public AudioSource expSound;

    void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Missile")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            speed = 0;
            mr.enabled = false;
            expSound.Play();
            explosion.Play();
            Destroy(this.gameObject,1f);
            ScoreScript.score++;
            Destroy(collision.gameObject);
        }
    }
}
