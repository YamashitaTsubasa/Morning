using UnityEngine;
using System.Collections;
public class BALLBROKEN : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball"){
            Destroy(other.gameObject,2.5f);
        }
    }
}
