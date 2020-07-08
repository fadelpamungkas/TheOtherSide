using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip jumpScareSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        jumpScareSound = Resources.Load<AudioClip>("jumpScare");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch(clip){
            case "jumpScare": 
                audioSrc.PlayOneShot(jumpScareSound);
                break;
        }
    }
}
