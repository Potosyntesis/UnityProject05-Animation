using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blendTreeAni : MonoBehaviour
{
    public float VelX, VelZ;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && VelZ <= 1f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.W) && VelZ <= 0.5f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if(VelZ >= 0)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && VelZ <= 1f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W) && VelZ <= 0.5f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (VelZ >= 0)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && VelZ <= 1f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W) && VelZ <= 0.5f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (VelZ >= 0)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }

        ani.SetFloat("VelocityX", VelX);
        ani.SetFloat("VelocityZ", VelZ);
    }
}