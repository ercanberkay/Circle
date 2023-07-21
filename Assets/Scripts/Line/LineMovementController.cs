using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovementController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    void Update()
    {
        SetLineLeftMovement();
    }

    void SetLineLeftMovement()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }
}
