using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedMove;

    public bool backside;
    // Start is called before the first frame update
    void Start()
    {
        backside = true;
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {

        if (backside)
        {
            rb.velocity = new Vector2(speedMove, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }else
        {
            rb.velocity = new Vector2(-speedMove, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Back"))
        {
            backside = !backside;
        }
    }
}
