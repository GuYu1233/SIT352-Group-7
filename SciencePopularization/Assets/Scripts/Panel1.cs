using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel1 : MonoBehaviour
{

    public Button[] NumBtn;
	void Start () 
    {
        for (int i = 0; i < NumBtn.Length; i++)
        {
            string Audioname = NumBtn[i].gameObject.name;
            NumBtn[i].onClick.AddListener(delegate { MusicManager2.Instance.PlayAudioSource(Audioname); });
        }
	}
	
	
	void Update () 
    {
		
	}

     
}
