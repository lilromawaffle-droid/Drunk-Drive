using System;
using UnityEngine;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{
    public Slider progresBar; 
    public Slider window;
    public void setProgres(float current)
    {
        progresBar.value = current;
    }

    public void setMax(float coba)
    {
        progresBar.maxValue = coba ;
    }
}
