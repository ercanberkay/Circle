using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] CircleInputController circleInputController;
    [SerializeField] CircleScoreController circleScoreController;

    public bool GetIsTouch()
    {
        return circleInputController.isTouch;
    }

    public void IncreaseScoreValue()
    {
        circleScoreController.IncreaseScoreValue();
    }
}
