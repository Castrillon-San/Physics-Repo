using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDraw : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] int nSamples = 5;
    [SerializeField] [Range(0f, 1f)] float separationFactor;
    [SerializeField] [Range(0f, 10f)] float y;
    [SerializeField] [Range(0f, 10f)] float noise;
    [SerializeField] [Range(0f, 10f)] float t;
    [SerializeField] float a = 0;
    void Start()
    {
        for (int i = 0; i < nSamples; i++)
        {
            Instantiate(prefab, transform);
        }
    }

    void Update()
    {
        int i = 0;
        a += Time.deltaTime;
        foreach (Transform item in transform)
        {
            float x = i * separationFactor;
            item.localPosition= new Vector3(x, Mathf.Sin(2*Mathf.PI*(x+a)/t) * y, 0);   // y = sin( 2 * Pi * (
            i++;    
        }
    }
}
