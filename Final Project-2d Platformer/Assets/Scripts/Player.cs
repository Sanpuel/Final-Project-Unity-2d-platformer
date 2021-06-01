using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed = 5;

    Rigidbody2D myRididBody;

    // Start is called before the first frame update
    void Start()
    {
        myRididBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
    }

    private void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRididBody.velocity.y);
        myRididBody.velocity = playerVelocity;
    }

    private void FlipSprite()
    {
        bool PlayerHasHorizontalSpeed = Mathf.Abs(myRididBody.velocity.x) > Mathf.Epsilon;
        if (PlayerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRididBody.velocity.x), 1f);
        }
    }
}
