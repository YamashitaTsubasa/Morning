using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOUND : MonoBehaviour
{
    public float bounce = 10f;
    public int scorepoint = 10;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball") 
        {
            other.rigidbody.AddForce(0, bounce / 4, bounce, ForceMode.Impulse);
            GameObject gm = GameObject.Find("GENERATER");
            gm.GetComponent<GENERATER>().AddScore(scorepoint);
        }
    }
}

// Start is called before the first frame update
