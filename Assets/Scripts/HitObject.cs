using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    MeshRenderer mesh;


    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            mesh.material.color = Color.red;

        }

    }
}
