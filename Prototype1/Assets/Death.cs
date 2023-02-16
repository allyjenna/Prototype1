using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject monster;
    public AnimationClip deathAnimation;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = monster.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Chest")
        {
            anim.clip = deathAnimation;
            anim.Play();
        }
    }
}
