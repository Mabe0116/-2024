using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Å@
    }

    // Update is called once per frame
    void Update()
    {
        const float moveJump = 4.0f;

        Vector3 v = rb.velocity;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            v.x = 0;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            v.x -= 0; 
        }
        rb.velocity = v;

        if(UnityEngine.Input.GetKey(KeyCode.Space)) 
        {
            v.y = moveJump;
        }
        
    }
}
