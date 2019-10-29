using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public Transform cam;

    public Vector3 minShrink, maxShrink;
    public bool shrinking, enlarged;
    

    public float speed;
    public Rigidbody2D rb;
    public Animator anim;
    public Vector2 move;

    public Joystick joystick;

    

    public GameObject bullet;

    public int enemyKillCount;

    
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;



        anim.SetFloat("speed", Mathf.Abs(move.x + move.y));


        if (transform.position.y >= cam.position.y-1)
        {
            transform.localScale -= Vector3.one * 2f * Time.deltaTime;
        }

        if (transform.localScale.y <= 0.5f)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (transform.position.y <= cam.position.y-1)
        {
            transform.localScale += Vector3.one * 2f * Time.deltaTime;
        }

        if (transform.localScale.y >= 1)
        {
            transform.localScale = Vector3.one;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }


}
