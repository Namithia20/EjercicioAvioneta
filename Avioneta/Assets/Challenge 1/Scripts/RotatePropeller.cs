using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public GameObject plane;
    private float speed = 360*10;
    
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
