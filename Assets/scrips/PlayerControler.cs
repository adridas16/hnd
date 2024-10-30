using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        //Set our input 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move when the user use key
        transform.Translate(Vector3.right.normalized * horizontalInput*Time.deltaTime*speed);
        transform.Translate(Vector3.forward.normalized*verticalInput*Time.deltaTime*speed);
    }
}
