using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIRCLE : MonoBehaviour
{
    public float rotAngle = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, rotAngle, 0f);
    }
}
