using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        if (Application.isEditor)
        {
            print("editerrrr");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
