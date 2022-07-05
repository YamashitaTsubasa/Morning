using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUDIO : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audio;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        

        

        if (other.gameObject.tag == "Player")
        {
            audio.PlayOneShot(sound01);
        }
        else if(other.gameObject.tag == "OTHER")
        {
            audio.PlayOneShot(sound02);
        }
        else if(other.gameObject.tag == "A")
        {
            audio.PlayOneShot(sound03);
            GameObject.Find("Canvas").GetComponent<UI>().AddScore();
        }
    }
    
}
