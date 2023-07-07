using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D playerRB;
    Vector2 movement;
    public LogicScript logic;
    public bool PlayerIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        FindObjectOfType<AudioManager>().Stop("MenuTheme");
        FindObjectOfType<AudioManager>().Play("tankEngine");
        FindObjectOfType<AudioManager>().Play("MainGameTheme");
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (PlayerIsAlive == true)
        {
            //movement
            playerRB.MovePosition(playerRB.position + movement * moveSpeed * Time.fixedDeltaTime);
        }

        if (transform.position.y < -1.3 || transform.position.y > 1.3)
        {
            logic.gameOver();
            PlayerIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().Play("TankCrash");
        FindObjectOfType<AudioManager>().Stop("tankEngine");

        logic.gameOver();
        PlayerIsAlive = false;
    }
}
