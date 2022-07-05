using UnityEngine;
using System.Collections;
public class BROKEN: MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}