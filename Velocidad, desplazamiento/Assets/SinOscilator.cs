using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinOscilator : MonoBehaviour
{
    
    float escalarX, escalarY;
    private void Start()
    {
        escalarX = Random.Range(-5, 5);
        escalarY = Random.Range(-5, 5);
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * escalarX * Mathf.Cos(Time.time), Mathf.Sin(Time.time) * escalarY, 0f);
    }
}
