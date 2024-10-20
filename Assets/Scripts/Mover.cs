using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    Rigidbody rb;
   float xValue ;
 
   float zValue ;

    [SerializeField] float playerSpeed; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        
        transform.Translate(xValue * Time.deltaTime * playerSpeed, 0 , zValue * Time.deltaTime * playerSpeed)   ;

    }
}
