using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 10f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float distance = direction.magnitude;
        direction = direction.normalized;
        transform.Translate(direction * speed *2* Time.deltaTime, Space.World);
        animator.SetFloat("Speed", distance);
    }
}
