using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public Vector3 mov;
    void Start()
    {
        
    }

    // segun esto as� es pero a mi no me sali� 
    void Update()
    {
        transform.position += mov;
    }
}
