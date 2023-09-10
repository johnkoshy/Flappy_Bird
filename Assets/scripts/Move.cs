using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.left * speed * Time.deltaTime;

        // Vector2 to denote x,y (0,1) coordinate only
        // Vector2.left to denote x,y coordinate is (-1,0) to left side that is -1 to x axis and 0 to y axis
        // deltaTime is the completion time is seconds since the last frame
    }
}
