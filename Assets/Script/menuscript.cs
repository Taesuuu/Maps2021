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
            for (int i = 0; i < 20; i++)
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
            for (int i = 0; i < 13; i++)
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

        // 나눔관 

        if (onechose == 5 && twochose == 1)
        {
            for (int i = 0; i < 13; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5101";
            classroom[0].gameObject.tag = "5101";
            classNum[1].text = "5102";
            classroom[1].gameObject.tag = "5102";
            classNum[2].text = "5103";
            classroom[2].gameObject.tag = "5103";
            classNum[3].text = "5104";
            classroom[3].gameObject.tag = "5104";
            classNum[4].text = "5106";
            classroom[4].gameObject.tag = "5106";
            classNum[5].text = "5107";
            classroom[5].gameObject.tag = "5107";
            classNum[6].text = "5108";
            classroom[6].gameObject.tag = "5108";
            classNum[7].text = "Healing Cafe";
            classroom[7].gameObject.tag = "5109";
            classNum[8].text = "5110";
            classroom[8].gameObject.tag = "5110";
            classNum[9].text = "5111";
            classroom[9].gameObject.tag = "5111";
            classNum[10].text = "JOB CAFE";
            classroom[10].gameObject.tag = "5113";
            classNum[11].text = "Cafe";
            classroom[11].gameObject.tag = "5116";
            classNum[12].text = "Bookstore";
            classroom[12].gameObject.tag = "5115";
        }
        if (onechose == 5 && twochose == 2)
        {
            for (int i = 0; i < 12; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5201";
            classroom[0].gameObject.tag = "5201";
            classNum[1].text = "5202";
            classroom[1].gameObject.tag = "5202";
            classNum[2].text = "5203";
            classroom[2].gameObject.tag = "5203";
            classNum[3].text = "5204";
            classroom[3].gameObject.tag = "5204";
            classNum[4].text = "5205";
            classroom[4].gameObject.tag = "5205";
            classNum[5].text = "5206";
            classroom[5].gameObject.tag = "5206";
            classNum[6].text = "5207";
            classroom[6].gameObject.tag = "5207";
            classNum[7].text = "5208";
            classroom[7].gameObject.tag = "5208";
            classNum[8].text = "5209";
            classroom[8].gameObject.tag = "5209";
            classNum[9].text = "5210";
            classroom[9].gameObject.tag = "5210";
            classNum[10].text = "5211";
            classroom[10].gameObject.tag = "5211";
            classNum[11].text = "5212";
            classroom[11].gameObject.tag = "5212";
            
        }
        if (onechose == 5 && twochose == 3)
        {
            for (int i = 0; i < 17; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5301";
            classroom[0].gameObject.tag = "5301";
            classNum[1].text = "5302";
            classroom[1].gameObject.tag = "5302";
            classNum[2].text = "5303";
            classroom[2].gameObject.tag = "5303";
            classNum[3].text = "5304";
            classroom[3].gameObject.tag = "5304";
            classNum[4].text = "5305";
            classroom[4].gameObject.tag = "5305";
            classNum[5].text = "5306";
            classroom[5].gameObject.tag = "5306";
            classNum[6].text = "5307";
            classroom[6].gameObject.tag = "5307";
            classNum[7].text = "5308";
            classroom[7].gameObject.tag = "5308";
            classNum[8].text = "5309";
            classroom[8].gameObject.tag = "5309";
            classNum[9].text = "5310";
            classroom[9].gameObject.tag = "5310";
            classNum[10].text = "5311";
            classroom[10].gameObject.tag = "5311";
            classNum[11].text = "5312";
            classroom[11].gameObject.tag = "5312";
            classNum[12].text = "5313";
            classroom[12].gameObject.tag = "5313";
            classNum[13].text = "5314";
            classroom[13].gameObject.tag = "5314";
            classNum[14].text = "5315";
            classroom[14].gameObject.tag = "5315";
           
              classNum[15].text = "5321";
              classroom[15].gameObject.tag = "5321";
              classNum[16].text = "5322";
              classroom[16].gameObject.tag = "5322"; 
        }
        if (onechose == 5 && twochose == 4)
        {
            for (int i = 0; i < 12; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5401";
            classroom[0].gameObject.tag = "5401";
            classNum[1].text = "5402";
            classroom[1].gameObject.tag = "5402";
            classNum[2].text = "5403";
            classroom[2].gameObject.tag = "5403";
            classNum[3].text = "5404";
            classroom[3].gameObject.tag = "5404";
            classNum[4].text = "5405";
            classroom[4].gameObject.tag = "5405";
            classNum[5].text = "5406";
            classroom[5].gameObject.tag = "5406";
            classNum[6].text = "5407";
            classroom[6].gameObject.tag = "5407";
            classNum[7].text = "5408";
            classroom[7].gameObject.tag = "5408";
            classNum[8].text = "5409";
            classroom[8].gameObject.tag = "5409";
            classNum[9].text = "5410";
            classroom[9].gameObject.tag = "5410";
            classNum[10].text = "5411";
            classroom[10].gameObject.tag = "5411";
            classNum[11].text = "5421";
            classroom[11].gameObject.tag = "5421";     
        }
        if (onechose == 5 && twochose == 5)
        {
            for (int i = 0; i < 14; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5501";
            classroom[0].gameObject.tag = "5501";
            classNum[1].text = "5502";
            classroom[1].gameObject.tag = "5502";
            classNum[2].text = "5503";
            classroom[2].gameObject.tag = "5503";
            classNum[3].text = "5504";
            classroom[3].gameObject.tag = "5504";
            classNum[4].text = "5505";
            classroom[4].gameObject.tag = "5505";
            classNum[5].text = "5506";
            classroom[5].gameObject.tag = "5506";
            classNum[6].text = "5507";
            classroom[6].gameObject.tag = "5507";
            classNum[7].text = "5508";
            classroom[7].gameObject.tag = "5508";
            classNum[8].text = "5509";
            classroom[8].gameObject.tag = "5509";
            classNum[9].text = "5510";
            classroom[9].gameObject.tag = "5510";
            classNum[10].text = "5511";
            classroom[10].gameObject.tag = "5511";
            classNum[11].text = "5512";
            classroom[11].gameObject.tag = "5512";
            classNum[12].text = "5521";
            classroom[12].gameObject.tag = "5521";
            classNum[13].text = "5522";
            classroom[13].gameObject.tag = "5522";           
        }
        if (onechose == 5 && twochose == 6)
        {
            for (int i = 0; i < 13; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "5601";
            classroom[0].gameObject.tag = "5601";
            classNum[1].text = "5602";
            classroom[1].gameObject.tag = "5602";
            classNum[2].text = "5603";
            classroom[2].gameObject.tag = "5603";
            classNum[3].text = "5604";
            classroom[3].gameObject.tag = "5604";
            classNum[4].text = "5605";
            classroom[4].gameObject.tag = "5605";
            classNum[5].text = "5606";
            classroom[5].gameObject.tag = "5606";
            classNum[6].text = "5607";
            classroom[6].gameObject.tag = "5607";
            classNum[7].text = "5608";
            classroom[7].gameObject.tag = "5608";
            classNum[8].text = "5609";
            classroom[8].gameObject.tag = "5609";
            classNum[9].text = "5610";
            classroom[9].gameObject.tag = "5610";
            classNum[10].text = "5611";
            classroom[10].gameObject.tag = "5611";
            classNum[11].text = "5612";
            classroom[11].gameObject.tag = "5612";
            classNum[12].text = "5621";
            classroom[12].gameObject.tag = "5621";          
        }
        if (onechose == 5 && twochose == 7)
        {
            for (int i = 0; i < 8; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "B5101";
            classroom[0].gameObject.tag = "5001";
            classNum[1].text = "B5102";
            classroom[1].gameObject.tag = "5002";
            classNum[2].text = "B5103";
            classroom[2].gameObject.tag = "5003";
            classNum[3].text = "B5104";
            classroom[3].gameObject.tag = "5004";
            classNum[4].text = "B5105";
            classroom[4].gameObject.tag = "5005";
            classNum[5].text = "B5106";
            classroom[5].gameObject.tag = "5006";
            classNum[6].text = "B5112";
            classroom[6].gameObject.tag = "5012";
            classNum[7].text = "B5113";
            classroom[7].gameObject.tag = "5013";     
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
        SceneManager.LoadScene(3);
        TargetChange.getClassRoom = int.Parse(la);
        
    }
}
