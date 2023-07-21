using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Color[] colors;
    int colorIndex;
    [SerializeField] float lerpValue;


    [SerializeField] float time;
    float currentTime;

   
    void Update()
    {
        ChangeSmoothCameraColor();
        SetColorChangeTime();
    }

    void ChangeSmoothCameraColor()
    {
        mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, colors[colorIndex], lerpValue * Time.deltaTime);
    }

    void SetColorChangeTime()
    {
        if (currentTime <= 0 )
        {
            IncreaseColorIndexValue();
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    void IncreaseColorIndexValue()
    {
        colorIndex++;
    }

    void CheckColorIndexValue()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void OnDestroy()
    {
        mainCamera.backgroundColor = colors[1];
    }
}
