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
        ani.SetFloat("VelocityX", VelX);
        ani.SetFloat("VelocityZ", VelZ);
    }
}
