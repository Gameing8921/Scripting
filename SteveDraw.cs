using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveDraw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20, 131, 49);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(19.5f, 132, 49);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20.5f, 132, 49);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20.5f, 133, 49);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(19.5f, 133, 49);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(20, 134, 49);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
