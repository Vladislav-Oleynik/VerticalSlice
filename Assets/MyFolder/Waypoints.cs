using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public float speed = 5f;
    public Vector3 target;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = waypoints[i].transform.position;
        transform.Translate(Vector3.Normalize(target - transform.position) * Time.deltaTime * speed);
        float distance = Vector3.Distance(target, transform.position);

        if (distance < 0.5f)
            i++;

        if (i > 3)
            i = 0;
    }
}
