using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Chest : MonoBehaviour
{
    public GameObject player;
    public GameObject chest;
    public GameObject monster;
 
    public int totalGems; // Total number of gems in the game
    public TextMeshProUGUI winText;  // UI text for displaying the "You win" message
    private Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GemPickUp gemPickUp = collision.gameObject.GetComponent<GemPickUp>();

        if (collision.collider.gameObject == player && gemPickUp != null && gemPickUp.count == totalGems)
            {
                winText.enabled = true;
            monster.GetComponent<Animator>().enabled = false;
            monster.GetComponent<FollowPlayer>().enabled = false;


        }
    }
    }

   
