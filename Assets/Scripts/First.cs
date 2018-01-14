using UnityEngine;
using System.Collections;

public class First : MonoBehaviour
{
    public Rigidbody rb;
    public float zf, xf, rf;
    // Use this for initialization
    void Start()
    {
        rb.velocity = new Vector3(0, 0, 7);
    }

    // Update is called once per frame
    void Update()
    {
        //Regular Force
        rb.AddForce(0, 0, rf* Time.deltaTime);
        //End at fall
        if (rb.position.y < 0.9)
        {
            FindObjectOfType<GM>().EndGame();
        }

        //Controls
        if (Input.GetKey("a"))
        {
            left(xf);
        }
        if (Input.GetKey("d"))
        {
            right(xf);
        }
        //Touchy
        /* if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).position.x<=250)
            {
                left(xf/3);
            }
            else if (Input.GetTouch(0).position.x >= 310)
            {
                right(xf/3);
            }
        }

        // Just for Debugging
      if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, zf * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("s"))
        {
            stop();
        }
        if (Input.GetKey("r"))
        {
            rb.position = new Vector3(0, 1, 5);
            stop();
        }
        */
        if (SystemInfo.deviceType== DeviceType.Handheld)
        {
             rb.transform.Translate(Input.acceleration.x, 0, 0);
        }
    }

    public void right(float force)
    {
        rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void left(float force)
    {
        rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void stop()
    {
        rb.velocity = new Vector3(0, 0, 0);
        transform.rotation = new Quaternion(0, 0, 0, 0);
        rb.angularVelocity = new Vector3(0, 0, 0);
    }
}
