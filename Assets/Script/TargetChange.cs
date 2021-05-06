using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetChange : MonoBehaviour
{

    public static int getClassRoom;
    public static string getco;



    void Start()
    {
        //DropdownClassRoom dropdownClassRoom = GameObject.Find("TextClassRoom").GetComponent<DropdownClassRoom>();

        //getClassRoom = dropdownClassRoom.getValue;

        //getClassRoom = IndexNum.indexsNum.numIndex;
        Debug.Log(getClassRoom);
        Debug.Log(getco);
        switch (getClassRoom)
        {
            //7-3F
            case 7301:
                this.transform.position = new Vector3(13, 0, 32);
                break;
            case 7302:
                this.transform.position = new Vector3(13, 0, 25);
                break;

            // 7-2F
            case 7201:
                this.transform.position = new Vector3(-30, 14, 1);
                break;
            case 7202:
                this.transform.position = new Vector3(-30, 14, -9);
                break;
            case 7203:
                this.transform.position = new Vector3(-30, 14, -20);
                break;
            case 7204:
                this.transform.position = new Vector3(-30, 14, -40);
                break;
            case 7205:
                this.transform.position = new Vector3(-45, 14, -72);
                break;
            case 7206:
                this.transform.position = new Vector3(-56, 14, -75);
                break;
            case 7207:
                this.transform.position = new Vector3(-61, 14, -50);
                break;
            case 7208:
                this.transform.position = new Vector3(-61, 14, -20);
                break;
            case 7209:
                this.transform.position = new Vector3(-61, 14, -6);
                break;
            case 7210:
                this.transform.position = new Vector3(-61, 14, 0);
                break;
            case 7211:
                this.transform.position = new Vector3(-52, 14, 1);
                break;
            case 7212:
                this.transform.position = new Vector3(-40, 14, -14);
                break;
            case 7213:
                this.transform.position = new Vector3(-40, 14, -41);
                break;

                // na seok hun

            case 5101:
                this.transform.position = new Vector3(12, 0, 49);
                break;
            case 5102:
                this.transform.position = new Vector3(12, 0, 37);
                break;
            case 5103:
                this.transform.position = new Vector3(12, 0, 27);
                break;
            case 5104:
                this.transform.position = new Vector3(12, 0, 17);
                break;
            case 5106:
                this.transform.position = new Vector3(12, 0, -33);
                break;
            case 5108:
                this.transform.position = new Vector3(12, 0, -44);
                break;
            case 5109:
                this.transform.position = new Vector3(12, 0, -62);
                break;
            case 5110:
                this.transform.position = new Vector3(-11, 0, 50);
                break;
            case 5111:
                this.transform.position = new Vector3(-11, 0, 37);
                break;
            case 5113:
                this.transform.position = new Vector3(-11, 0, -8);
                break;
            case 5201:
                this.transform.position = new Vector3(41, 0, 49);
                break;
            case 5202:
                this.transform.position = new Vector3(41, 0, 39);
                break;
            case 5203:
                this.transform.position = new Vector3(41, 0, 24);
                break;
            case 5204:
                this.transform.position = new Vector3(41, 0, 8);
                break;
            case 5205:
                this.transform.position = new Vector3(41, 0, -11);
                break;
            case 5206:
                this.transform.position = new Vector3(41, 0, -29);
                break;
            case 5207:
                this.transform.position = new Vector3(41, 0, -47);
                break;
            case 5208:
                this.transform.position = new Vector3(41, 0, -64);
                break;
            case 5209:
                this.transform.position = new Vector3(18, 0, 49);
                break;
            case 5210:
                this.transform.position = new Vector3(18, 0, 37);
                break;
            case 5211:
                this.transform.position = new Vector3(5, 0, -71);
                break;
            case 5212:
                this.transform.position = new Vector3(-13, 0, -71);
                break;
            case 5301:
                this.transform.position = new Vector3(11, 0, 61);
                break;
            case 5302:
                this.transform.position = new Vector3(11, 0, 52);
                break;
            case 5303:
                this.transform.position = new Vector3(11, 0, 43);
                break;
            case 5304:
                this.transform.position = new Vector3(11, 0, 32);
                break;
            case 5305:
                this.transform.position = new Vector3(11, 0, 22);
                break;
            case 5306:
                this.transform.position = new Vector3(11, 0, 14);
                break;
            case 5307:
                this.transform.position = new Vector3(11, 0, 3);
                break;
            case 5308:
                this.transform.position = new Vector3(11, 0, -6);
                break;
            case 5309:
                this.transform.position = new Vector3(11, 0, -16);
                break;
            case 5310:
                this.transform.position = new Vector3(11, 0, -26);
                break;
            case 5311:
                this.transform.position = new Vector3(11, 0, -35);
                break;
            case 5312:
                this.transform.position = new Vector3(11, 0, -44);
                break;
            case 5313:
                this.transform.position = new Vector3(11, 0, -66);
                break;
            case 5314:
                this.transform.position = new Vector3(-13, 0, 49);
                break;
            case 5315:
                this.transform.position = new Vector3(-13, 0, 36);
                break;
            case 5321:
                this.transform.position = new Vector3(-23, 0, -72);
                break;
            case 5322:
                this.transform.position = new Vector3(-41, 0, -72);
                break;
            case 5401:
                this.transform.position = new Vector3(12, 0, 63);
                break;
            case 5402:
                this.transform.position = new Vector3(12, 0, 52);
                break;
            case 5403:
                this.transform.position = new Vector3(12, 0, 43);
                break;
            case 5404:
                this.transform.position = new Vector3(12, 0, 31);
                break;
            case 5405:
                this.transform.position = new Vector3(12, 0, 19);
                break;
            case 5406:
                this.transform.position = new Vector3(12, 0, 2);
                break;
            case 5407:
                this.transform.position = new Vector3(12, 0, -27);
                break;
            case 5408:
                this.transform.position = new Vector3(12, 0, -50);
                break;
            case 5409:
                this.transform.position = new Vector3(12, 0, -64);
                break;
            case 5410:
                this.transform.position = new Vector3(-12, 0, 48);
                break;
            case 5411:
                this.transform.position = new Vector3(-12, 0, 36);
                break;
            case 5421:
                this.transform.position = new Vector3(-35, 0,-73);
                break;
            case 5501:
                this.transform.position = new Vector3(12, 0, 64);
                break;
            case 5502:
                this.transform.position = new Vector3(12, 0, 52);
                break;
            case 5503:
                this.transform.position = new Vector3(12, 0, 44);
                break;
            case 5504:
                this.transform.position = new Vector3(12, 0, 32);
                break;
            case 5505:
                this.transform.position = new Vector3(12, 0, 21);
                break;
            case 5506:
                this.transform.position = new Vector3(12, 0, 8);
                break;
            case 5507:
                this.transform.position = new Vector3(12, 0, -10);
                break;
            case 5508:
                this.transform.position = new Vector3(12, 0, -28);
                break;
            case 5509:
                this.transform.position = new Vector3(12, 0, -47);
                break;
            case 5510:
                this.transform.position = new Vector3(12, 0, -65);
                break;
            case 5511:
                this.transform.position = new Vector3(-12, 0, 48);
                break;
            case 5512:
                this.transform.position = new Vector3(-12, 0, 36);
                break;
            case 5521:
                this.transform.position = new Vector3(-41, 0, -71);
                break;
            case 5522:
                this.transform.position = new Vector3(-23, 0, 64);
                break;
            case 5601:
                this.transform.position = new Vector3(12, 0, 64);
                break;
            case 5602:
                this.transform.position = new Vector3(12, 0, 52);
                break;
            case 5603:
                this.transform.position = new Vector3(12, 0, 44);
                break;
            case 5604:
                this.transform.position = new Vector3(12, 0, 32);
                break;
            case 5605:
                this.transform.position = new Vector3(12, 0, 21);
                break;
            case 5606:
                this.transform.position = new Vector3(12, 0, 8);
                break;
            case 5607:
                this.transform.position = new Vector3(12, 0, -10);
                break;
            case 5608:
                this.transform.position = new Vector3(12, 0, -28);
                break;
            case 5609:
                this.transform.position = new Vector3(12, 0, -47);
                break;
            case 5610:
                this.transform.position = new Vector3(12, 0, -65);
                break;
            case 5611:
                this.transform.position = new Vector3(-12, 0, 48);
                break;
            case 5612:
                this.transform.position = new Vector3(-12, 0, 36);
                break;
            case 5621:
                this.transform.position = new Vector3(-33, 0, -72);
                break;

            case 5001:
                this.transform.position = new Vector3(11, 0, 49);
                break;
            case 5002:
                this.transform.position = new Vector3(11, 0, 38);
                break;
            case 5003:
                this.transform.position = new Vector3(11, 0, 25);
                break;
            case 5004:
                this.transform.position = new Vector3(-19, 0, 0);
                break;
            case 5005:
                this.transform.position = new Vector3(-19, 0, -32);
                break;
            case 5006:
                this.transform.position = new Vector3(-17, 0, -62);
                break;
            case 5012:
                this.transform.position = new Vector3(-12, 0, 50);
                break;
            case 5013:
                this.transform.position = new Vector3(-12, 0, 37);
                break;









            default:
                break;


        }

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void changesss()
    {










    }
}
