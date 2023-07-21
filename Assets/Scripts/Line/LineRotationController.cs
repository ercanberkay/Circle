using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    [SerializeField] float rotationValue;
    float randomRotation;
    void Start()
    {
        GenerateRandomRotationValue();
        SetLineRotation();
    }


    void GenerateRandomRotationValue()
    {
        randomRotation = Random.Range(-rotationValue, rotationValue);
    }

    void SetLineRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
    }
}
