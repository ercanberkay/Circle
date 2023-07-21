using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{

    [SerializeField] float endXValue;
    void Update()
    {
        CheckLinePositionX();
    }

    void CheckLinePositionX()
    {
        if (transform.position.x <= endXValue)
        {
            Destroy(gameObject);
        }
    }
}
