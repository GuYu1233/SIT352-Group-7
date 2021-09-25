using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel3 : MonoBehaviour
{

    public Sprite[] NumSprite;

    public Image Image0;
	public Image Image1;

    private int CurrentPro = 5;
    private int CurrentScore = 0;
    public Button[] NumBtn;

    public Text Text;
    public Text ScText; 

    //计算
    private int AllNum;
    private int CurrentNum1;
    private int CurrentNum2;
    void Start ()
    {
        CalcNum();
        for (int i = 0; i < NumBtn.Length; i++)
        {
            string Audioname = NumBtn[i].gameObject.name;
            NumBtn[i].onClick.AddListener(delegate
            {
                OnClickNumBtn(Audioname);
            });
        }
    }

    void CalcNum()
    {
        while (true)
        {
            CurrentNum1 = Random.Range(0, 10);
            CurrentNum2 = Random.Range(0, 10);

            if (CurrentNum1 + CurrentNum2 <= 9)
            {
                break;
            }
        }

        AllNum = CurrentNum1 + CurrentNum2;
        Image0.sprite = NumSprite[CurrentNum1];
        Image1.sprite = NumSprite[CurrentNum2];
    }

    void OnClickNumBtn(string name)
    {
        if (name == AllNum.ToString())
        {
            CurrentScore += 20;
            MusicManager2.Instance.PlayAudioSource(name);

            CurrentPro--;
            if (CurrentPro == 0)
            {
                Text.text = "恭喜通关！";
                GameObject.Find("Panel3").gameObject.SetActive(false);
                GameObject.Find("Panel3_2").gameObject.SetActive(false);
            }

            CalcNum();
        }
        else
        {
            CurrentScore -= 10;
        }

        ScText.text = "分数:" + CurrentScore;

    }

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            CalcNum();
        }
	}
}
