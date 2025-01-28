using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Valo : MonoBehaviour
{
    public Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Color newColor = new Color(0.3f, 0.4f, 0.6f);
            light.color = newColor;
        }
    }
}
