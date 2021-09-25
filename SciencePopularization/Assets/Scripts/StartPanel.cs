using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{


    public Button[] Btn;
    public GameObject MenuPanel;

    public Slider[] Slider;

    public GameObject BG1;
    public Button[] Btn2;
    public GameObject ARPanelBtnText3;

    void Start()
    {
        Btn[0].onClick.AddListener(QuitGame);
        Btn[1].onClick.AddListener(OnClickMenuBtn);
        Btn[2].onClick.AddListener(CloseMenu);

        Slider[0].onValueChanged.AddListener(MusicManager.Instance.SetAudioSourceVOLUME1);

        BG1.gameObject.SetActive(true);
        StartCoroutine(ShowBG1());

        Btn2[0].onClick.AddListener(delegate { SceneManager.LoadScene("ARPanel"); });
        Btn2[1].onClick.AddListener(delegate { SceneManager.LoadScene("ShowPanel"); });
        Btn2[2].onClick.AddListener(delegate { ARPanelBtnText3.gameObject.SetActive(!ARPanelBtnText3.activeSelf); });
    }


    void Update()
    {

    }

    IEnumerator ShowBG1()
    {
        yield return new WaitForSeconds(1.5f);
        BG1.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OnClickMenuBtn()
    {
        MenuPanel.gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
        MenuPanel.gameObject.SetActive(false);
    }


}