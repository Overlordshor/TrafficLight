using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject Red;
    public GameObject Green;
    public GameObject Yellow;

    public void SelectRed()
    {
            Red.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            Green.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            Yellow.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
    
    public void SelectGreen()
    {
            Green.GetComponent<Renderer>().material.color = new Color(0, 1f, 0);
            Yellow.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            Red.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        
    }
    public void SelectYellow()
    {
            Yellow.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0);
            Green.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            Red.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    private void Start()
    {
        LightOff();
    }
    
    private void LightOff()
    {
        Green.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        Yellow.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        Red.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
}
