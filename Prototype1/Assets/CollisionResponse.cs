using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionResponse : MonoBehaviour
{
    public GameObject player;
    public GameObject monster;
    public TextMeshProUGUI gameOverText;
    public AnimationClip deathAnimation;

    private Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("Collision detected");
            gameOverText.enabled = true;
            monster.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<FollowPlayer>().enabled = false;
        }
        if (collision.gameObject.tag == "Player")
        {
            anim.clip = deathAnimation;
            anim.Play();
        }
    }
}
