using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextPanel : MonoBehaviour
{

    public Button NextButton;
	
	void Start () {
        NextButton.onClick.AddListener(OnClickNextButton);
	}
	
	
	void Update () {
		
	}

    void OnClickNextButton()
    {
        if (SceneManager.GetActiveScene().name == "1")
        {
            SceneManager.LoadScene("2");
        }

        if (SceneManager.GetActiveScene().name == "2")
        {
            SceneManager.LoadScene("3");
        }

        if (SceneManager.GetActiveScene().name == "3")
        {
            SceneManager.LoadScene("Over");
        }
    }
}
