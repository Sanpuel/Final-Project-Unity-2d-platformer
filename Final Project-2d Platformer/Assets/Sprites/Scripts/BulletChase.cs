using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletChase : MonoBehaviour
{
    float movespeed = 7f;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;
     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
