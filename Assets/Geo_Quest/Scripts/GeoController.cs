using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    public int speed = 5;
    Rigidbody2D rb;
    string String = "Hello ";
    int Player1 = 3;

    // Start is called before the first frame update
    void Start()
    {
        
        rb= GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String+String2);

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Player1);
        Player1++;

        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -2, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(2, 0, 0);
        }
        

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(1,rb.velocity.x);
        }
        

        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput, rb.velocity.y);
        */

        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);
    }
        
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Run Killer");

        switch (collision.tag)
        {
            case "finish":
                {
                    string thislevel=SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
        }
    }




}

