using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float speed = 15f;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    int tmr = 3;
    float h = Input.GetAxis("Horizontal");
    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            Debug.Log("Pew-Пиу!");
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * new Vector3(1f, 0, 0);
            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}
