using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float moveSpeed = 65;
    public Transform player;
    public Rigidbody enemy;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "bullet")
        {
            Rigidbody enemyClone = Instantiate(enemy, transform.position, transform.rotation) as Rigidbody;
        }
    }
   
}
