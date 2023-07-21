using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{

    [SerializeField] CircleDataTransmitter circleDataTransmitter;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float circleJumpForce;


    private void FixedUpdate()
    {
        SetCircleJump();
    }

    void SetCircleJump()
    {
        if (circleDataTransmitter.GetIsTouch())
        {
            rb.velocity = Vector2.up * circleJumpForce * Time.fixedDeltaTime;
        }
        
    }
}
