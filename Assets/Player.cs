using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float JumpForce = 3.5f;

    public bool isFalling = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.AddForce(Vector3.up * JumpForce, ForceMode2D.Impulse);
            }
        }

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        print(" On Collision Enter");
        if (other.gameObject.CompareTag("Ground"))
        {
            
             isFalling = false;
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }
}
