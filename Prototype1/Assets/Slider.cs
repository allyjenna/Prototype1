using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    private float speed = 1.0f; // Movement speed
    private float distance = 1.0f; // Distance to move
    private Vector3 startPosition; // Starting position

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Move the object back and forth
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPosition + Vector3.right * offset;
    }
}
