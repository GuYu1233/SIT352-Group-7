using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager2 : MonoBehaviour {

    public static MusicManager2 Instance;

    private AudioSource AudioSource;

    void Start()
    {
        Instance = this;
        AudioSource = gameObject.GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetAudioSourceVOLUME1(float VOLUME)
    {
        AudioSource.volume = VOLUME;
    }

    public void PlayAudioSource(string name)
    {
        AudioClip AudioClip = Resources.Load<AudioClip>("Audio/" + name);
        AudioSource.clip = AudioClip;
        AudioSource.Play();
    }
}
