using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public GameObject wheel;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
    }

    private void Awake()
    {
        Debug.Log("Awake Called");
    }

    private void OnEnable()
    {
        Debug.Log("Enable Called");
    }

    private void OnDisable()
    {
        Debug.Log("Disable Called");
    }


    // Update is called once per frame
    void Update()
    {
        //wheel.transform.Rotate(0,0,10);
    }
}
