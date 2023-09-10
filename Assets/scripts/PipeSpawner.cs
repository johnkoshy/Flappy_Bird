using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float maxTime = 1.5f;
    float timer = 0;
    public GameObject column;
    public float minHeight;
    public float maxHeight;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newColumn = Instantiate(column); // creating a copy of GameObject 
        newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
        Destroy(newColumn, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newColumn = Instantiate(column); // creating a copy of GameObject 
            newColumn.transform.position = (Vector2)transform.position + Vector2.up * Random.Range(minHeight, maxHeight);
            Destroy(newColumn, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
