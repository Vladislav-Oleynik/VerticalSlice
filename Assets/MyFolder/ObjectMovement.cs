using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float radius = 2f;
    public float angle = 0f;
    public float speed = 2f;

    void Update()
    {
        angle += Time.deltaTime;
        var x = Mathf.Cos(angle * speed) * radius;
        var z = Mathf.Sin(angle * speed) * radius;
        transform.position = new Vector3(x, 0.5f, z);
    }
}
