using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARPanel : MonoBehaviour
{
    public Button[] Btn;
    public Slider Slider;
    public Slider ARSlider;

    public GameObject ARPanelBtnText3;
    public GameObject MenuPanel;
    void Start()
    {
        Btn[0].onClick.AddListener(QuitGame);
        Btn[1].onClick.AddListener(OnClickMenuBtn);
        Btn[2].onClick.AddListener(CloseMenu);
        Btn[3].onClick.AddListener(OnClickUSEBtn);
        Btn[4].onClick.AddListener(OnClickReturnGame);
        Slider.onValueChanged.AddListener(MusicManager.Instance.SetAudioSourceVOLUME1);
        ARSlider.onValueChanged.AddListener(delegate(float value) { GameObject.Find("Directional Light").GetComponent<Light>().intensity = value;});
    }

    private void OnClickReturnGame()
    {
        SceneManager.LoadScene("Start");
    }

    private void OnClickUSEBtn()
    {
        ARPanelBtnText3.gameObject.SetActive(!ARPanelBtnText3.activeSelf);
    }

    private void CloseMenu()
    {
        MenuPanel.gameObject.SetActive(false);
    }

    private void OnClickMenuBtn()
    {
        MenuPanel.gameObject.SetActive(true);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
