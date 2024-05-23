using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleScript : MonoBehaviour
{
    public void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
    }
}
