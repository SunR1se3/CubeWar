using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBull : MonoBehaviour
{
    public float maxSpeed = 5f;
    public int timeLife = 50;

    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;
        timeLife--;
        if (timeLife <= 0)
            Destroy(gameObject);
    }
}
