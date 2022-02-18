using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    
    public HealthBar healthBar;

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
        _rigidbody = GetComponent<Rigidbody2D>();
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity; 

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce),  ForceMode2D.Impulse);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
