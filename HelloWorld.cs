using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        if (Application.isPlaying)
        {
            print("Playin");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
