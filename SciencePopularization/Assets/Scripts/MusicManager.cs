using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    public static MusicManager Instance;

    private AudioSource AudioSource;

    void Awake()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject);
            return;
        }

        AudioSource = gameObject.GetComponent<AudioSource>();

        Instance = this;
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

}
