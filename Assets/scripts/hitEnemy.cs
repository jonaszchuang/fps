using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitEnemy : MonoBehaviour
{
    public Rigidbody enemy;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "bullet")
            {
                enemy.transform = spawn;
                Rigidbody newEnemy = Instantiate(enemy, spawn.position, enemy.rotation) as Rigidbody;
            }
        }
    }
}
