using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCanvas : MonoBehaviour
{

    public Transform Obj;
    public float currentScale;
    private float CurrentS;
    private float RScale;
    private GameObject DesText;

    private bool isRotate = false;
    void Start()
    {
        Obj = gameObject.transform.parent.transform.GetChild(0).transform;
        CurrentS = currentScale;
        RScale = currentScale / 10;


        transform.Find("BIG").gameObject.GetComponent<Button>().onClick.AddListener(OnClickBig);
        transform.Find("sm").gameObject.GetComponent<Button>().onClick.AddListener(OnClickSM);
        transform.Find("Use").gameObject.GetComponent<Button>().onClick.AddListener(delegate
        {
            bool show = !DesText.gameObject.activeSelf; DesText.gameObject.SetActive(show); transform.Find("Bg").gameObject.SetActive(show);
            transform.Find("Close").gameObject.SetActive(show);

        });
        transform.Find("Close").gameObject.GetComponent<Button>().onClick.AddListener(delegate
        {
            bool show = false; DesText.gameObject.SetActive(show); transform.Find("Bg").gameObject.SetActive(show);
            transform.Find("Close").gameObject.SetActive(show);

        });
        DesText = transform.Find("DesText").gameObject;

        transform.Find("rotate").gameObject.GetComponent<Button>().onClick.AddListener(Crotate);
    }


    void Update()
    {
        if (isRotate)
        {
            Obj.Rotate(Vector3.up * Time.deltaTime * 100);
        }
    }

    void Crotate()
    {
        isRotate = !isRotate;
    }


    void OnClickBig()
    {
        currentScale += RScale;

        if (currentScale > CurrentS * 2)
        {
            return;
        }
        Obj.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    void OnClickSM()
    {
        currentScale -= RScale;

        if (currentScale < CurrentS / 2)
        {
            return;
        }
        Obj.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }
}
