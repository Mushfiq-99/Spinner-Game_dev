using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool isRotate=false;
    public float rotationSpeed= 500f;
    public float multiplier = 0.9f;
    public GameObject needle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed = Random.Range(700f, 1000f);
            multiplier = Random.Range(0.95f, 0.97f);
            isRotate = true;
        }

        

        if(isRotate)
        {   rotationSpeed = rotationSpeed * multiplier;
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            needle.SetActive(true);
        }
    }
}