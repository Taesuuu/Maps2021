using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class menuscript : MonoBehaviour
{
    public int onechose;
    public int twochose;

    public string getstag;
    public string getfloor;

    public string fi;
    public string cn;
    public string la;


    public GameObject menus;
    public GameObject submenu;
    public GameObject lastmenu;
    public GameObject finsh;

    public GameObject[] floors;
    public GameObject[] classroom;

    public TextMeshProUGUI[] classNum;
    public TextMeshProUGUI lastch;

    // Start is called before the first frame update
    void Start()
    {
        menus.SetActive(false);
        submenu.SetActive(false);
        lastmenu.SetActive(false);
        finsh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void menuup()
    {
        menus.SetActive(true);
    }
    public void menudown()
    {
        menus.SetActive(false);
        submenu.SetActive(false);
        lastmenu.SetActive(false);
    }
    public void goyuhan()
    {
        getstag = EventSystem.current.currentSelectedGameObject.tag;

        for (int i = 0; i < floors.Length; i++)
        {
            floors[i].SetActive(false);
        }

        switch (getstag)
        {
            case "1": onechose = 1;
                fi = "평화관";
                break;
            case "2":
                onechose = 2;
                fi = "봉사관";
                break;
            case "3":
                onechose = 3;
                fi = "자유관";
                break;
            case "4":
                onechose = 4;
                fi = "학생회관";
                break;
            case "5":
                onechose = 5;
                fi = "나눔관";
                break;
            case "6":
                onechose = 6;
                fi = "창조관";
                break;
            case "7":
                onechose = 7;
                fi = "유일한기념관";
                break;
            case "8":
                onechose = 8;
                fi = "유재라관";
                break;
        }

        if (onechose == 1)
        {
            for (int i = 0; i < 7; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 2)
        {
            for (int i = 0; i < 8; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 3)
        {
            for (int i = 0; i < 5; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 5)
        {
            for (int i = 0; i < 7; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 6)
        {
            for (int i = 0; i < 7; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 7)
        {
            for (int i = 0; i < 6; i++)
            {
                floors[i].SetActive(true);
            }
        }
        else if (onechose == 8)
        {
            for (int i = 0; i < 7; i++)
            {
                floors[i].SetActive(true);
            }
        }
        submenu.SetActive(true);
        Debug.Log(onechose);
    }
    public void subyuhan()
    {
        getfloor = EventSystem.current.currentSelectedGameObject.tag;

        for (int i = 0; i < classroom.Length; i++)
        {
            classroom[i].SetActive(false);
        }

        switch (getfloor)
        {
            case "1F":
                twochose = 1;
                cn = "1층";
                break;
            case "2F":
                twochose = 2;
                cn = "2층";
                break;
            case "3F":
                twochose = 3;
                cn = "3층";
                break;
            case "4F":
                twochose = 4;
                cn = "4층";
                break;
            case "5F":
                twochose = 5;
                cn = "5층";
                break;
            case "6F":
                twochose = 6;
                cn = "6층";
                break;
            case "B1":
                twochose = 7;
                cn = "B1층";
                break;
            case "B2":
                twochose = 8;
                cn = "B2층";
                break;
        }
        lastmenu.SetActive(true);


        if (onechose == 7 && twochose == 1)
        {
            for (int i = 0; i < classroom.Length; i++)
            {
                classroom[i].SetActive(false);
            }
        }
        if (onechose == 7 && twochose == 2)
        {
            for (int i = 0; i < 12; i++)
            {
                classroom[i].SetActive(true);
            }

            classNum[0].text = "7201";
            classroom[0].gameObject.tag = "7201";
            classNum[1].text = "7202";
            classroom[1].gameObject.tag = "7202";
            classNum[2].text = "7203";
            classroom[2].gameObject.tag = "7203";
            classNum[3].text = "7204";
            classroom[3].gameObject.tag = "7204";
            classNum[4].text = "7205";
            classroom[4].gameObject.tag = "7205";
            classNum[5].text = "7206";
            classroom[5].gameObject.tag = "7206";
            classNum[6].text = "7207";
            classroom[6].gameObject.tag = "7207";
            classNum[7].text = "7208";
            classroom[7].gameObject.tag = "7208";
            classNum[8].text = "7209";
            classroom[8].gameObject.tag = "7209";
            classNum[9].text = "7210";
            classroom[9].gameObject.tag = "7210";
            classNum[10].text = "7211";
            classroom[10].gameObject.tag = "7211";
            classNum[11].text = "7212";
            classroom[11].gameObject.tag = "7212";
            classNum[12].text = "7213";
            classroom[12].gameObject.tag = "7213";
        }
        if (onechose == 7 && twochose == 3)
        {
            for (int i = 0; i < 12; i++)
            {
                classroom[i].SetActive(true);
            }
            
            classNum[0].text = "7301";
            classroom[0].gameObject.tag = "7301";
            classNum[1].text = "7302";
            classroom[1].gameObject.tag = "7302";
            classNum[2].text = "7303";
            classroom[2].gameObject.tag = "7303";
            classNum[3].text = "7304";
            classroom[3].gameObject.tag = "7304";
            classNum[4].text = "7305";
            classroom[4].gameObject.tag = "7305";
            classNum[5].text = "7306";
            classroom[5].gameObject.tag = "7306";
            classNum[6].text = "7307";
            classroom[6].gameObject.tag = "7307";
            classNum[7].text = "7308";
            classroom[7].gameObject.tag = "7308";
            classNum[8].text = "7309";
            classroom[8].gameObject.tag = "7309";
            classNum[9].text = "7310";
            classroom[9].gameObject.tag = "7310";
            classNum[10].text = "7311";
            classroom[10].gameObject.tag = "7311";
            classNum[11].text = "7312";
            classroom[11].gameObject.tag = "7312";
            classNum[12].text = "7313";
            classroom[12].gameObject.tag = "7313";
        }
        if (onechose == 7 && twochose == 4)
        {
            for (int i = 0; i < 1; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "뉴스퀘어";
            classroom[0].gameObject.tag = "뉴스퀘어";

        }
        if (onechose == 7 && twochose == 5)
        {
            for (int i = 0; i < 1; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "도서관";
            classroom[0].gameObject.tag = "도서관";

        }
        if (onechose == 7 && twochose == 6)
        {
            for (int i = 0; i < 1; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "도서관";
            classroom[0].gameObject.tag = "도서관";

        }
        Debug.Log(twochose);
    }

    public void goclassrom()
    {
        la = EventSystem.current.currentSelectedGameObject.tag;
        finsh.SetActive(true);
        lastch.text = fi + " " + cn + " " + la;
       
    }

    public void rego()
    {
        SceneManager.LoadScene("newMain");
    }
    public void nextgo()
    {
        SceneManager.LoadScene(1);
        TargetChange.getClassRoom = int.Parse(la);
        
    }
}
