using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ani : MonoBehaviour
{
    public float vel, leftRotate, rightRotate;
    Animator ani;
    //Rigidbody man;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            vel += 0.5f * Time.deltaTime;
            if (vel >= 1f)
            {
                vel = 1f;
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (vel > 0.1f)
            {
                vel -= 0.5f * Time.deltaTime;
            }
            else if(vel <= 0.1f)
            {
                vel += 0.5f * Time.deltaTime;
            }
            else
            {
                vel = 0.1f;
            }
        }
        else
        {
            vel -= 0.8f * Time.deltaTime;
            if (vel <= 0)
            {
                vel = 0f;
            }
        }
        ani.SetFloat("Velocity", vel);
        if (Input.GetKey(KeyCode.A))
        {
            ani.transform.Rotate(0, -1, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ani.transform.Rotate(0, 1, 0, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ani.transform.Rotate(0, 180, 0, Space.Self);
        }
    }
}
