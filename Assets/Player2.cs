using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    float timeSize = 0f;
    bool down, jump, stop = false;
    float timeStop = 0f;
    public Text myText;
    public float jumpVelocity;

    void Start()
    {
        jumpVelocity = 10f;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && jump == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            jump = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(transform.localScale.x, 0.25f, transform.localScale.z);
            down = true;
        }
        if (down)
        {
            timeSize += Time.deltaTime;
            if (timeSize > 1)
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
                down = false;
                timeSize = 0f;
            }
        }

        if (transform.position.x < -7.216654 && transform.position.z > -8.704716)
        {
            myText.text = "Player 1 Wins!";
            stop = true;
        }

        if(stop)
        {
            timeStop += Time.deltaTime;
            if (timeStop > 1)
                Time.timeScale = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
            jump = true;
    }
}
