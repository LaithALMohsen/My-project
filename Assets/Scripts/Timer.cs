using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    Rigidbody rb;
   [SerializeField] int timer;
    MeshRenderer mesh; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();

        mesh.enabled = false;
        rb.useGravity = false;
    }

   
    void Update()
    {
        if(Time.time >=  timer)
        {



            mesh.enabled = true;
            rb.useGravity = true;

        }



    }
}
