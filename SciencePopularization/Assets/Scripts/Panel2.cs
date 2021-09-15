using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Panel2 : MonoBehaviour {

    public Button[] NumBtn;
    private int CurrentNum;

    public GameObject Panel2Obj;
    public GameObject Panel2_2Obj;
    public GameObject TipText;
    void Start()
    {
        CurrentNum = 0;
        for (int i = 0; i < NumBtn.Length; i++)
        {
            string Audioname = NumBtn[i].gameObject.name;
            NumBtn[i].onClick.AddListener(delegate { 
                OnClickNumBtn(Audioname);
            });
        }
    }


    void OnClickNumBtn(string name)
    {
        if (CurrentNum.ToString() != name)
        {
            return;
        }

        MusicManager2.Instance.PlayAudioSource(name);

        Panel2Obj.transform.Find(name).GetComponent<Image>().color = new Color(255f/255f, 255f / 255f, 255f / 255f, 255f / 255f);
        Panel2_2Obj.transform.Find(name).gameObject.SetActive(false);

        CurrentNum++;
        TipText.transform.Find("Text").GetComponent<Text>().text = "请找到:" + CurrentNum;
        if (CurrentNum>9)
        {
            TipText.transform.Find("Text").GetComponent<Text>().text = "恭喜通关！";
        }
    }
    // Update is called once per frame
    void Update () 
    {
		
	}

}
