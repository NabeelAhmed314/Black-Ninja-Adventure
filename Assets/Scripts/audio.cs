using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource myaudio;
    // Start is called before the first frame update
    void Start()
    {
        myaudio = GetComponent<AudioSource>();
        myaudio.clip = Resources.Load<AudioClip>("bgSound");
        myaudio.Play();
        DontDestroyOnLoad(myaudio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
