using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody bullet;
    public Transform cannon;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Fire();
    }
    void Fire()
    {
        Rigidbody bulletClone = Instantiate(bullet, cannon.position, cannon.rotation) as Rigidbody;
        bulletClone.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        Destroy(bulletClone, 5);
    }
}