using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool isRotate=false;
    public float rotationSpeed;
    public float multiplier;
    public GameObject needle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotationSpeed < 1f)
        {
            isRotate = false;
            float z = transform.rotation.eulerAngles.z;
            ColorPicker(z);
      
        }
        if(!isRotate && Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed = Random.Range(3700f, 4000f);
            multiplier = Random.Range(0.95f, 0.97f);
            isRotate = true;
        }

        

        if(isRotate)
        {   rotationSpeed = rotationSpeed * multiplier;
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            needle.SetActive(true);
        }
        
        
    }

    void ColorPicker(float z)
    {
        if (z >= 1f && z <= 60f)
        {
            Debug.Log("Orange");
        }
        else if (z >= 61f && z <= 120f)
        {
            Debug.Log("Yellow");
        }
            
        else if (z >= 121f && z <= 180f)
        {
            Debug.Log("Light Green");
        }
        else if (z >= 181f && z <= 240f)
        {
            Debug.Log("Sky Blue");
        }
        else if (z >= 241f && z <= 300f)
        {
            Debug.Log("Purple");
        }
        else if (z >= 301f && z <= 360f)
        {
            Debug.Log("Pink");
        }

    }
}