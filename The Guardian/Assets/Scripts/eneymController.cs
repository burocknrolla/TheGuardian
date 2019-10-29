using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eneymController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.right * -speed);

        rb.velocity = Vector2.left * speed * Time.fixedDeltaTime;

        if (health < 0)
        {
            Destroy(gameObject);
            PlayerController play = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            play.enemyKillCount++;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            health -= 50;

            Destroy(collision.gameObject);
           
        }
    }
}
