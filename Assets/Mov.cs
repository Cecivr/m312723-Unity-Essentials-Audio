using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public Vector3 mov;
    void Start()
    {
        
    }

    // segun esto así es pero a mi no me salió 
    void Update()
    {
        transform.position += mov;
    }
}
