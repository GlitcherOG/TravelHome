using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed = 5f;
    void Update()
    {
        //Get the input from the Horizontal and vertical buttons and then changed the location based on it
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(inputH, 0, inputV);
        rigid.AddForce(direction * speed);
    }
}
