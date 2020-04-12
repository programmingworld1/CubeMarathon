using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForece = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, forwardForce * Time.deltaTime), ForceMode.Impulse);

        if(Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(sidewaysForece * Time.deltaTime, 0, 0), ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-sidewaysForece * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }

        if(transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
