using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 1f;
    Rigidbody2D myRigidBody;



    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidBody.velocity = new Vector2(movespeed, 0f);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-movespeed, 0f);
        }
    }

    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-4.84f*(Mathf.Sign(myRigidBody.velocity.x)), 6.17f);
    }
}
