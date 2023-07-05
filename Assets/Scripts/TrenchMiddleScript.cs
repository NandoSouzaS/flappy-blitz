using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenchMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update() { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && player.PlayerIsAlive == true)
        {
            logic.addScore(1);
        }
    }
}
