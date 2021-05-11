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
    public void menuup()
    {
        menus.SetActive(true);
    }
    public void menudown()
    {
        menus.SetActive(false);
        submenu.SetActive(false);
        lastmenu.SetActive(false);
        finsh.SetActive(false);
    }
    public void goyuhan()
    {
        lastmenu.SetActive(false);
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
            for (int i = 0; i < 9; i++)
            {
                floors[i].SetActive(true);
            }
            floors[6].SetActive(false);
            floors[7].SetActive(false);
        }
        else if (onechose == 2)
        {
            for (int i = 0; i < 8; i++)
            {
                floors[i].SetActive(true);
            }
            floors[5].SetActive(false);
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
            for (int i = 0; i < 6; i++)
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
            case "PH":
                twochose = 9;
                cn = "PH층";
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

        if (onechose == 8 && twochose == 1)
        {
            for (int i = 0; i < 1; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "행정실";
            classroom[0].gameObject.tag = "행정실";
        }
        if (onechose == 8 && twochose == 2)
        {
            for (int i = 0; i < 12; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "8201";
            classroom[0].gameObject.tag = "8201";
            classNum[1].text = "8202";
            classroom[1].gameObject.tag = "8202";
            classNum[2].text = "8203";
            classroom[2].gameObject.tag = "8203";
            classNum[3].text = "8204";
            classroom[3].gameObject.tag = "8204";
            classNum[4].text = "8205";
            classroom[4].gameObject.tag = "8205";
            classNum[5].text = "8206";
            classroom[5].gameObject.tag = "8206";
            classNum[6].text = "8207";
            classroom[6].gameObject.tag = "8207";
            classNum[7].text = "8208";
            classroom[7].gameObject.tag = "8208";
            classNum[8].text = "8209";
            classroom[8].gameObject.tag = "8209";
            classNum[9].text = "8210";
            classroom[9].gameObject.tag = "8210";
            classNum[10].text = "8211";
            classroom[10].gameObject.tag = "8211";
            classNum[11].text = "8212";
            classroom[11].gameObject.tag = "8212";
        }
        if (onechose == 8 && twochose == 3)
        {
            for (int i = 0; i < 24; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "8301";
            classroom[0].gameObject.tag = "8301";
            classNum[1].text = "8302";
            classroom[1].gameObject.tag = "8302";
            classNum[2].text = "8303";
            classroom[2].gameObject.tag = "8303";
            classNum[3].text = "8304";
            classroom[3].gameObject.tag = "8304";
            classNum[4].text = "8305";
            classroom[4].gameObject.tag = "8305";
            classNum[5].text = "8306";
            classroom[5].gameObject.tag = "8306";
            classNum[6].text = "8307";
            classroom[6].gameObject.tag = "8307";
            classNum[7].text = "8308";
            classroom[7].gameObject.tag = "8308";
            classNum[8].text = "8309";
            classroom[8].gameObject.tag = "8309";
            classNum[9].text = "8310";
            classroom[9].gameObject.tag = "8310";
            classNum[10].text = "8311";
            classroom[10].gameObject.tag = "8311";
            classNum[11].text = "8312";
            classroom[11].gameObject.tag = "8312";
            classNum[12].text = "8313";
            classroom[12].gameObject.tag = "8313";
            classNum[13].text = "8314";
            classroom[13].gameObject.tag = "8314";
            classNum[14].text = "8315";
            classroom[14].gameObject.tag = "8315";
            classNum[15].text = "8316";
            classroom[15].gameObject.tag = "8316";
            classNum[16].text = "8317";
            classroom[16].gameObject.tag = "8317";
            classNum[17].text = "8318";
            classroom[17].gameObject.tag = "8318";
            classNum[18].text = "8319";
            classroom[18].gameObject.tag = "8319";
            classNum[19].text = "8320";
            classroom[19].gameObject.tag = "8320";
            classNum[20].text = "8321";
            classroom[20].gameObject.tag = "8321";
            classNum[21].text = "8322";
            classroom[21].gameObject.tag = "8322";
            classNum[22].text = "8323";
            classroom[22].gameObject.tag = "8323";
            classNum[23].text = "8324";
            classroom[23].gameObject.tag = "8324";
        }
        if (onechose == 8 && twochose == 4)
        {
            for (int i = 0; i < 24; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "8401";
            classroom[0].gameObject.tag = "8401";
            classNum[1].text = "8402";
            classroom[1].gameObject.tag = "8402";
            classNum[2].text = "8403";
            classroom[2].gameObject.tag = "8403";
            classNum[3].text = "8404";
            classroom[3].gameObject.tag = "8404";
            classNum[4].text = "8405";
            classroom[4].gameObject.tag = "8405";
            classNum[5].text = "8406";
            classroom[5].gameObject.tag = "8406";
            classNum[6].text = "8407";
            classroom[6].gameObject.tag = "8407";
            classNum[7].text = "8408";
            classroom[7].gameObject.tag = "8408";
            classNum[8].text = "8409";
            classroom[8].gameObject.tag = "8409";
            classNum[9].text = "8410";
            classroom[9].gameObject.tag = "8410";
            classNum[10].text = "8411";
            classroom[10].gameObject.tag = "8411";
            classNum[11].text = "8412";
            classroom[11].gameObject.tag = "8412";
            classNum[12].text = "8413";
            classroom[12].gameObject.tag = "8413";
            classNum[13].text = "8414";
            classroom[13].gameObject.tag = "8414";
            classNum[14].text = "8415";
            classroom[14].gameObject.tag = "8415";
            classNum[15].text = "8416";
            classroom[15].gameObject.tag = "8416";
            classNum[16].text = "8417";
            classroom[16].gameObject.tag = "8417";
            classNum[17].text = "8418";
            classroom[17].gameObject.tag = "8418";
            classNum[18].text = "8419";
            classroom[18].gameObject.tag = "8419";
            classNum[19].text = "8420";
            classroom[19].gameObject.tag = "8420";
            classNum[20].text = "8421";
            classroom[20].gameObject.tag = "8421";
            classNum[21].text = "8422";
            classroom[21].gameObject.tag = "8422";
            classNum[22].text = "8423";
            classroom[22].gameObject.tag = "8423";
            classNum[23].text = "8424";
            classroom[23].gameObject.tag = "8424";
        }
        if (onechose == 8 && twochose == 5)
        {
            for (int i = 0; i < 13; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "8501";
            classroom[0].gameObject.tag = "8501";
            classNum[1].text = "8502";
            classroom[1].gameObject.tag = "8502";
            classNum[2].text = "8503";
            classroom[2].gameObject.tag = "8503";
            classNum[3].text = "8504";
            classroom[3].gameObject.tag = "8504";
            classNum[4].text = "8505";
            classroom[4].gameObject.tag = "8505";
            classNum[5].text = "8506";
            classroom[5].gameObject.tag = "8506";
            classNum[6].text = "8507";
            classroom[6].gameObject.tag = "8507";
            classNum[7].text = "8508";
            classroom[7].gameObject.tag = "8508";
            classNum[8].text = "8509";
            classroom[8].gameObject.tag = "8509";
            classNum[9].text = "8510";
            classroom[9].gameObject.tag = "8510";
            classNum[10].text = "8511";
            classroom[10].gameObject.tag = "8511";
            classNum[11].text = "8512";
            classroom[11].gameObject.tag = "8512";
            classNum[12].text = "8513";
            classroom[12].gameObject.tag = "8513";
        }
        if (onechose == 8 && twochose == 6)
        {
            for (int i = 0; i < 6; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "8601";
            classroom[0].gameObject.tag = "8601";
            classNum[1].text = "8602";
            classroom[1].gameObject.tag = "8602";
            classNum[2].text = "8603";
            classroom[2].gameObject.tag = "8603";
            classNum[3].text = "8604";
            classroom[3].gameObject.tag = "8604";
            classNum[4].text = "8605";
            classroom[4].gameObject.tag = "8605";
            classNum[5].text = "8606";
            classroom[5].gameObject.tag = "8606";
        }


        //봉사관

        if (onechose == 2 && twochose == 8)
        {
            for (int i = 0; i < 6; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "B2201";
            classroom[0].gameObject.tag = "82201";
            classNum[1].text = "B2202";
            classroom[1].gameObject.tag = "82202";
            classNum[2].text = "B2203";
            classroom[2].gameObject.tag = "82203";
            classNum[3].text = "B2204";
            classroom[3].gameObject.tag = "82204";
            classNum[4].text = "B2205";
            classroom[4].gameObject.tag = "82205";
            classNum[5].text = "B2206";
            classroom[5].gameObject.tag = "82206";
        }

        if (onechose == 2 && twochose == 7)
        {
            for (int i = 0; i < 6; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "B2101";
            classroom[0].gameObject.tag = "82101";
            classNum[1].text = "B2102";
            classroom[1].gameObject.tag = "82102";
            classNum[2].text = "B2103";
            classroom[2].gameObject.tag = "82103";
            classNum[3].text = "B2104";
            classroom[3].gameObject.tag = "82104";
            classNum[4].text = "B2105";
            classroom[4].gameObject.tag = "82105";
            classNum[5].text = "B2106";
            classroom[5].gameObject.tag = "82106";
        }

        if (onechose == 2 && twochose == 1)
        {
            for (int i = 0; i < 11; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "2101";
            classroom[0].gameObject.tag = "2101";
            classNum[1].text = "2102";
            classroom[1].gameObject.tag = "2102";
            classNum[2].text = "2103";
            classroom[2].gameObject.tag = "2103";
            classNum[3].text = "2104";
            classroom[3].gameObject.tag = "2104";
            classNum[4].text = "2105";
            classroom[4].gameObject.tag = "2105";
            classNum[5].text = "2106";
            classroom[5].gameObject.tag = "2106";
            classNum[6].text = "2107";
            classroom[6].gameObject.tag = "2107";
            classNum[7].text = "2108";
            classroom[7].gameObject.tag = "2108";
            classNum[8].text = "2109";
            classroom[8].gameObject.tag = "2109";
            classNum[9].text = "2110";
            classroom[9].gameObject.tag = "2110";
            classNum[10].text = "2111";
            classroom[10].gameObject.tag = "2111";
        }

        if (onechose == 2 && twochose == 2)
        {
            for (int i = 0; i < 11; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "2201";
            classroom[0].gameObject.tag = "2201";
            classNum[1].text = "2202";
            classroom[1].gameObject.tag = "2202";
            classNum[2].text = "2203";
            classroom[2].gameObject.tag = "2203";
            classNum[3].text = "2204";
            classroom[3].gameObject.tag = "2204";
            classNum[4].text = "2205";
            classroom[4].gameObject.tag = "2205";
            classNum[5].text = "2206";
            classroom[5].gameObject.tag = "2206";
            classNum[6].text = "2207";
            classroom[6].gameObject.tag = "2207";
            classNum[7].text = "2208";
            classroom[7].gameObject.tag = "2208";
            classNum[8].text = "2209";
            classroom[8].gameObject.tag = "2209";
            classNum[9].text = "2210";
            classroom[9].gameObject.tag = "2210";
            classNum[10].text = "2211";
            classroom[10].gameObject.tag = "2211";
        }

        if (onechose == 2 && twochose == 3)
        {
            for (int i = 0; i < 11; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "2301";
            classroom[0].gameObject.tag = "2301";
            classNum[1].text = "2302";
            classroom[1].gameObject.tag = "2302";
            classNum[2].text = "2303";
            classroom[2].gameObject.tag = "2303";
            classNum[3].text = "2304";
            classroom[3].gameObject.tag = "2304";
            classNum[4].text = "2305";
            classroom[4].gameObject.tag = "2305";
            classNum[5].text = "2306";
            classroom[5].gameObject.tag = "2306";
            classNum[6].text = "2307";
            classroom[6].gameObject.tag = "2307";
            classNum[7].text = "2308";
            classroom[7].gameObject.tag = "2308";
            classNum[8].text = "2309";
            classroom[8].gameObject.tag = "2309";
            classNum[9].text = "2310";
            classroom[9].gameObject.tag = "2310";
            classNum[10].text = "2311";
            classroom[10].gameObject.tag = "2311";
        }

        if (onechose == 2 && twochose == 4)
        {
            for (int i = 0; i < 13; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "2401";
            classroom[0].gameObject.tag = "2401";
            classNum[1].text = "2402";
            classroom[1].gameObject.tag = "2402";
            classNum[2].text = "2403";
            classroom[2].gameObject.tag = "2403";
            classNum[3].text = "2404";
            classroom[3].gameObject.tag = "2404";
            classNum[4].text = "2405";
            classroom[4].gameObject.tag = "2405";
            classNum[5].text = "2406";
            classroom[5].gameObject.tag = "2406";
            classNum[6].text = "2407";
            classroom[6].gameObject.tag = "2407";
            classNum[7].text = "2408";
            classroom[7].gameObject.tag = "2408";
            classNum[8].text = "2409";
            classroom[8].gameObject.tag = "2409";
            classNum[9].text = "2410";
            classroom[9].gameObject.tag = "2410";
            classNum[10].text = "2411";
            classroom[10].gameObject.tag = "2411";
            classNum[11].text = "2412";
            classroom[11].gameObject.tag = "2412";
            classNum[12].text = "2413";
            classroom[12].gameObject.tag = "2413";
        }

        if (onechose == 2 && twochose == 5)
        {
            for (int i = 0; i < 8; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "2501";
            classroom[0].gameObject.tag = "2501";
            classNum[1].text = "2502";
            classroom[1].gameObject.tag = "2502";
            classNum[2].text = "2503";
            classroom[2].gameObject.tag = "2503";
            classNum[3].text = "2504";
            classroom[3].gameObject.tag = "2504";
            classNum[4].text = "2505";
            classroom[4].gameObject.tag = "2505";
            classNum[5].text = "2506";
            classroom[5].gameObject.tag = "2506";
            classNum[6].text = "2507";
            classroom[6].gameObject.tag = "2507";
            classNum[7].text = "2508";
            classroom[7].gameObject.tag = "2508";            
        }

        // 6호관 
        // 6-B1
        if (onechose == 6 && twochose == 7)
        {
            for (int i = 0; i < 8; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "76101";
            classroom[0].gameObject.tag = "76101";
            classNum[1].text = "76102";
            classroom[1].gameObject.tag = "76102";
            classNum[2].text = "76103_1";
            classroom[2].gameObject.tag = "76103_1";
            classNum[3].text = "76103_2";
            classroom[3].gameObject.tag = "76103_2";
            classNum[4].text = "76104";
            classroom[4].gameObject.tag = "76104";
            classNum[5].text = "76105";
            classroom[5].gameObject.tag = "76105";
            classNum[6].text = "76106";
            classroom[6].gameObject.tag = "76106"; // 소강당
            classNum[7].text = "76107";
            classroom[7].gameObject.tag = "76107";
            classNum[8].text = "76108";
            classroom[8].gameObject.tag = "76108";
        }

        // 6-1 
        if (onechose == 6 && twochose == 1)
        {
            for (int i = 0; i < 6; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6101";
            classroom[0].gameObject.tag = "6101";
            classNum[1].text = "6102";
            classroom[1].gameObject.tag = "6102";
            classNum[2].text = "6103";
            classroom[2].gameObject.tag = "6103";
            classNum[3].text = "6104";
            classroom[3].gameObject.tag = "6104";
            classNum[4].text = "6105";
            classroom[4].gameObject.tag = "6105";
            classNum[5].text = "6106";
            classroom[5].gameObject.tag = "6106";
            classNum[6].text = "6107";
            classroom[6].gameObject.tag = "6107";
        }

        // 6-2 
        if (onechose == 6 && twochose == 2)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6201";
            classroom[0].gameObject.tag = "6201";
            classNum[1].text = "6202";
            classroom[1].gameObject.tag = "6202";
            classNum[2].text = "6203";
            classroom[2].gameObject.tag = "6203";
            classNum[3].text = "6204";
            classroom[3].gameObject.tag = "6204";
            classNum[4].text = "6205";
            classroom[4].gameObject.tag = "6205";
            classNum[5].text = "6206";
            classroom[5].gameObject.tag = "6206";
            classNum[6].text = "6207";
            classroom[6].gameObject.tag = "6207";
            classNum[7].text = "6208";
            classroom[7].gameObject.tag = "6208";
        }

        // 6-3
        if (onechose == 6 && twochose == 3)
        {
            for (int i = 0; i < 10; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6301";
            classroom[0].gameObject.tag = "6301";
            classNum[1].text = "6302";
            classroom[1].gameObject.tag = "6302";
            classNum[2].text = "6303";
            classroom[2].gameObject.tag = "6303";
            classNum[3].text = "6304";
            classroom[3].gameObject.tag = "6304";
            classNum[4].text = "6305";
            classroom[4].gameObject.tag = "6305";
            classNum[5].text = "6306";
            classroom[5].gameObject.tag = "6306";
            classNum[6].text = "6307";
            classroom[6].gameObject.tag = "6307";
            classNum[7].text = "6308";
            classroom[7].gameObject.tag = "6308";
            classNum[8].text = "6309";
            classroom[8].gameObject.tag = "6309";
            classNum[9].text = "6310";
            classroom[9].gameObject.tag = "6310";
            classNum[10].text = "6311";
            classroom[10].gameObject.tag = "6311";
        }

        // 6-4
        if (onechose == 6 && twochose == 4)
        {
            for (int i = 0; i < 6; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6401";
            classroom[0].gameObject.tag = "6401";
            classNum[1].text = "6402";
            classroom[1].gameObject.tag = "6402";
            classNum[2].text = "6403";
            classroom[2].gameObject.tag = "6403";
            classNum[3].text = "6404";
            classroom[3].gameObject.tag = "6404";
            classNum[4].text = "6405";
            classroom[4].gameObject.tag = "6405";
            classNum[5].text = "6406";
            classroom[5].gameObject.tag = "6406";
            classNum[6].text = "6407";
            classroom[6].gameObject.tag = "6407";
        }

        // 6-5
        if (onechose == 6 && twochose == 5)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6501";
            classroom[0].gameObject.tag = "6501";
            classNum[1].text = "6502";
            classroom[1].gameObject.tag = "6502";
            classNum[2].text = "6503";
            classroom[2].gameObject.tag = "6503";
            classNum[3].text = "6504";
            classroom[3].gameObject.tag = "6504";
            classNum[4].text = "6505";
            classroom[4].gameObject.tag = "6505";
            classNum[5].text = "6506";
            classroom[5].gameObject.tag = "6506";
            classNum[6].text = "6507";
            classroom[6].gameObject.tag = "6507";
            classNum[7].text = "6508";
            classroom[7].gameObject.tag = "6508";
        }

        // 6-6
        if (onechose == 6 && twochose == 6)
        {
            for (int i = 0; i < 17; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "6601";
            classroom[0].gameObject.tag = "6301";
            classNum[1].text = "6602";
            classroom[1].gameObject.tag = "6302";
            classNum[2].text = "6603";
            classroom[2].gameObject.tag = "6303";
            classNum[3].text = "6604";
            classroom[3].gameObject.tag = "6304";
            classNum[4].text = "6605";
            classroom[4].gameObject.tag = "6305";
            classNum[5].text = "6606";
            classroom[5].gameObject.tag = "6306";
            classNum[6].text = "6607";
            classroom[6].gameObject.tag = "6307";
            classNum[7].text = "6608";
            classroom[7].gameObject.tag = "6308";
            classNum[8].text = "6609";
            classroom[8].gameObject.tag = "6309";
            classNum[9].text = "6610";
            classroom[9].gameObject.tag = "6310";
            classNum[10].text = "6611";
            classroom[10].gameObject.tag = "6311";
            classNum[10].text = "6612";
            classroom[10].gameObject.tag = "6312";
            classNum[10].text = "6613";
            classroom[10].gameObject.tag = "6313";
            classNum[10].text = "6614";
            classroom[10].gameObject.tag = "6314";
            classNum[10].text = "6615";
            classroom[10].gameObject.tag = "6315";
            classNum[10].text = "6616";
            classroom[10].gameObject.tag = "6316";
            classNum[10].text = "6617";
            classroom[10].gameObject.tag = "6317";
            classNum[10].text = "6618";
            classroom[10].gameObject.tag = "6318";
        }

        // 1호관
        
        if (onechose == 1 && twochose == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1101";
            classroom[0].gameObject.tag = "1101";
            classNum[1].text = "1102";
            classroom[1].gameObject.tag = "1102";
            classNum[2].text = "1103";
            classroom[2].gameObject.tag = "1103";
            classNum[3].text = "1104";
            classroom[3].gameObject.tag = "1104";
        }

        if (onechose == 1 && twochose == 2)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1201";
            classroom[0].gameObject.tag = "1201";
            classNum[1].text = "1202";
            classroom[1].gameObject.tag = "1202";
            classNum[2].text = "1203";
            classroom[2].gameObject.tag = "1203";
            classNum[3].text = "1204";
            classroom[3].gameObject.tag = "1204";
            classNum[4].text = "1205";
            classroom[4].gameObject.tag = "1205";
            classNum[5].text = "1206";
            classroom[5].gameObject.tag = "1206";
            classNum[6].text = "1207";
            classroom[6].gameObject.tag = "1207";
        }
        if (onechose == 1 && twochose == 3)
        {
            for (int i = 0; i < 9; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1301";
            classroom[0].gameObject.tag = "1301";
            classNum[1].text = "1302";
            classroom[1].gameObject.tag = "1302";
            classNum[2].text = "1303";
            classroom[2].gameObject.tag = "1303";
            classNum[3].text = "1304";
            classroom[3].gameObject.tag = "1304";
            classNum[4].text = "1305";
            classroom[4].gameObject.tag = "1305";
            classNum[5].text = "1306";
            classroom[5].gameObject.tag = "1306";
            classNum[6].text = "1307";
            classroom[6].gameObject.tag = "1307";
            classNum[7].text = "1308";
            classroom[7].gameObject.tag = "1308";
            classNum[8].text = "1309";
            classroom[8].gameObject.tag = "1309";
        }

        if (onechose == 1 && twochose == 4)
        {
            for (int i = 0; i < 5; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1401";
            classroom[0].gameObject.tag = "1401";
            classNum[1].text = "1402";
            classroom[1].gameObject.tag = "1402";
            classNum[2].text = "1403";
            classroom[2].gameObject.tag = "1403";
            classNum[3].text = "1404";
            classroom[3].gameObject.tag = "1404";
            classNum[4].text = "1405";
            classroom[4].gameObject.tag = "1405";
        }

        if (onechose == 1 && twochose == 5)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1501";
            classroom[0].gameObject.tag = "1501";
            classNum[1].text = "1502";
            classroom[1].gameObject.tag = "1502";
            classNum[2].text = "1503";
            classroom[2].gameObject.tag = "1503";
            classNum[3].text = "1504";
            classroom[3].gameObject.tag = "1504";
            classNum[4].text = "1505";
            classroom[4].gameObject.tag = "1505";
            classNum[5].text = "1506";
            classroom[5].gameObject.tag = "1506";
            classNum[6].text = "1507";
            classroom[6].gameObject.tag = "1507";

        }

        if (onechose == 1 && twochose == 6)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1601";
            classroom[0].gameObject.tag = "1601";
            classNum[1].text = "1602";
            classroom[1].gameObject.tag = "1602";
            classNum[2].text = "1603";
            classroom[2].gameObject.tag = "1603";
            classNum[3].text = "1604";
            classroom[3].gameObject.tag = "1604";
            classNum[4].text = "1605";
            classroom[4].gameObject.tag = "1605";
            classNum[5].text = "1606";
            classroom[5].gameObject.tag = "1606";
            classNum[6].text = "1607";
            classroom[6].gameObject.tag = "1607";

        }

        if (onechose == 1 && twochose == 9)
        {
            for (int i = 0; i < 1; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "1701";
            classroom[0].gameObject.tag = "1701";

        }

        if (onechose == 3 && twochose == 7)
        {
            for (int i = 0; i < 20; i++)
            {

                classroom[i].SetActive(true);
            }
            classNum[0].text = "73101";
            classroom[0].gameObject.tag = "73101";
            classNum[1].text = "73102";
            classroom[1].gameObject.tag = "73102";
            classNum[2].text = "73103";
            classroom[2].gameObject.tag = "73103";
            classNum[3].text = "73104";
            classroom[3].gameObject.tag = "73104";
            classNum[4].text = "73105";
            classroom[4].gameObject.tag = "73105";
            classNum[5].text = "73106";
            classroom[5].gameObject.tag = "73106";
        }

        if (onechose == 3 && twochose == 1)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "3101";
            classroom[0].gameObject.tag = "3101";
            classNum[1].text = "3102";
            classroom[1].gameObject.tag = "3102";
            classNum[2].text = "3103";
            classroom[2].gameObject.tag = "3103";
            classNum[3].text = "3104";
            classroom[3].gameObject.tag = "3104";
            classNum[4].text = "3105";
            classroom[4].gameObject.tag = "3105";
            classNum[5].text = "3106";
            classroom[5].gameObject.tag = "3106";
            classNum[6].text = "3107";
            classroom[6].gameObject.tag = "3107";
        }

        if (onechose == 3 && twochose == 2)
        {
            for (int i = 0; i < 7; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "3201";
            classroom[0].gameObject.tag = "3201";
            classNum[1].text = "3202";
            classroom[1].gameObject.tag = "3202";
            classNum[2].text = "3203";
            classroom[2].gameObject.tag = "3203";
            classNum[3].text = "3204";
            classroom[3].gameObject.tag = "3204";
            classNum[4].text = "3205";
            classroom[4].gameObject.tag = "3205";
            classNum[5].text = "3206";
            classroom[5].gameObject.tag = "3206";
            classNum[6].text = "3207";
            classroom[6].gameObject.tag = "3207";
        }

        if (onechose == 3 && twochose == 3)
        {
            for (int i = 0; i < 8; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "3301";
            classroom[0].gameObject.tag = "3201";
            classNum[1].text = "3302";
            classroom[1].gameObject.tag = "3202";
            classNum[2].text = "3303";
            classroom[2].gameObject.tag = "3203";
            classNum[3].text = "3304";
            classroom[3].gameObject.tag = "3204";
            classNum[4].text = "3305";
            classroom[4].gameObject.tag = "3205";
            classNum[5].text = "3306";
            classroom[5].gameObject.tag = "3206";
            classNum[6].text = "3307";
            classroom[6].gameObject.tag = "3207";
            classNum[7].text = "3308";
            classroom[7].gameObject.tag = "3308";
        }

        if (onechose == 3 && twochose == 4)
        {
            for (int i = 0; i < 8; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "3401";
            classroom[0].gameObject.tag = "3401";
            classNum[1].text = "3402";
            classroom[1].gameObject.tag = "3402";
            classNum[2].text = "3403";
            classroom[2].gameObject.tag = "3403";
            classNum[3].text = "3404";
            classroom[3].gameObject.tag = "3404";
            classNum[4].text = "3405";
            classroom[4].gameObject.tag = "3405";
            classNum[5].text = "3406";
            classroom[5].gameObject.tag = "3406";
            classNum[6].text = "3407";
            classroom[6].gameObject.tag = "3407";
            classNum[7].text = "3408";
            classroom[7].gameObject.tag = "3408";
        }

        if (onechose == 3 && twochose == 5)
        {
            for (int i = 0; i < 10; i++)
            {
                classroom[i].SetActive(true);
            }
            classNum[0].text = "3501";
            classroom[0].gameObject.tag = "3501";
            classNum[1].text = "3502";
            classroom[1].gameObject.tag = "3502";
            classNum[2].text = "3503";
            classroom[2].gameObject.tag = "3503";
            classNum[3].text = "3504";
            classroom[3].gameObject.tag = "3504";
            classNum[4].text = "3505";
            classroom[4].gameObject.tag = "3505";
            classNum[5].text = "3506";
            classroom[5].gameObject.tag = "3506";
            classNum[6].text = "3507";
            classroom[6].gameObject.tag = "3507";
            classNum[7].text = "3508";
            classroom[7].gameObject.tag = "3508";
            classNum[8].text = "3509";
            classroom[8].gameObject.tag = "3509";
            classNum[9].text = "3510";
            classroom[9].gameObject.tag = "3510";
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
        SceneManager.LoadScene("Map");
        goclassRoom.oneclass = onechose;
        goclassRoom.twoclass = twochose;
        maptarget.gogo = onechose;
        TargetChange.getClassRoom = int.Parse(la);

    }
}
