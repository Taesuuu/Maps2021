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
            // 2-B2
            case 82201:
                this.transform.position = new Vector3(-14, 15, -71);
                break;
            case 82202:
                this.transform.position = new Vector3(-11, 15, -19);
                break;
            case 82203:
                this.transform.position = new Vector3(-11, 15, -6);
                break;
            case 82204:
                this.transform.position = new Vector3(-18, 15, 34);
                break;
            case 82205:
                this.transform.position = new Vector3(-45, 15, 4);
                break;
            case 82206:
                this.transform.position = new Vector3(-27, 15, -20);
                break;

            // 2-B1
            case 72101:
                this.transform.position = new Vector3(-22, 15, -53);
                break;
            case 72102:
                this.transform.position = new Vector3(-22, 15, -43);
                break;
            case 72103:
                this.transform.position = new Vector3(-22, 15, -33);
                break;
            case 72104:
                this.transform.position = new Vector3(-22, 15, -12);
                break;
            case 72105:
                this.transform.position = new Vector3(-22, 15, 5);
                break;
            case 72106:
                this.transform.position = new Vector3(-42, 15, 34);
                break;

            // 2-1
            case 2101:
                this.transform.position = new Vector3(-27, 15, -71);
                break;
            case 2102:
                this.transform.position = new Vector3(-27, 15, -49);
                break;
            case 2103:
                this.transform.position = new Vector3(-27, 15, -34);
                break;
            case 2104:
                this.transform.position = new Vector3(-27, 15, -14);
                break;
            case 2105:
                this.transform.position = new Vector3(-27, 15, -7);
                break;
            case 2106:
                this.transform.position = new Vector3(-27, 15, 1);
                break;
            case 2107:
                this.transform.position = new Vector3(-27, 15, 9);
                break;
            case 2108:
                this.transform.position = new Vector3(-27, 15, 17);
                break;
            case 2109:
                this.transform.position = new Vector3(-19, 15, 33);
                break;
            case 2110:
                this.transform.position = new Vector3(-42, 15, 33);
                break;

            // 2-2
            case 2201:
                this.transform.position = new Vector3(-27, 15, -72);
                break;
            case 2202:
                this.transform.position = new Vector3(-27, 15, -60);
                break;
            case 2203:
                this.transform.position = new Vector3(-27, 15, -47);
                break;
            case 2204:
                this.transform.position = new Vector3(-27, 15, -34);
                break;
            case 2205:
                this.transform.position = new Vector3(-27, 15, -16);
                break;
            case 2206:
                this.transform.position = new Vector3(-27, 15, -8);
                break;
            case 2207:
                this.transform.position = new Vector3(-27, 15, 0);
                break;
            case 2208:
                this.transform.position = new Vector3(-27, 15, 13);
                break;
            case 2209:
                this.transform.position = new Vector3(-27, 15, 20);
                break;
            case 2210:
                this.transform.position = new Vector3(-19, 15, 34);
                break;
            case 2211:
                this.transform.position = new Vector3(-42, 15, 34);
                break;

            // 2-3
            case 2301:
                this.transform.position = new Vector3(-27, 15, -71);
                break;
            case 2302:
                this.transform.position = new Vector3(-27, 15, -64);
                break;
            case 2303:
                this.transform.position = new Vector3(-27, 15, -55);
                break;
            case 2304:
                this.transform.position = new Vector3(-27, 15, -47);
                break;
            case 2305:
                this.transform.position = new Vector3(-27, 15, -39);
                break;
            case 2306:
                this.transform.position = new Vector3(-27, 15, -31);
                break;
            case 2307:
                this.transform.position = new Vector3(-27, 15, -8);
                break;
            case 2308:
                this.transform.position = new Vector3(-27, 15, 5);
                break;
            case 2309:
                this.transform.position = new Vector3(-27, 15, 18);
                break;
            case 2310:
                this.transform.position = new Vector3(-19, 15, 35);
                break;
            case 2311:
                this.transform.position = new Vector3(-43, 15, 34);
                break;

            // 2-4
            case 2401:
                this.transform.position = new Vector3(-27, 15, -70);
                break;
            case 2402:
                this.transform.position = new Vector3(-27, 15, -61);
                break;
            case 2403:
                this.transform.position = new Vector3(-27, 15, -52);
                break;
            case 2404:
                this.transform.position = new Vector3(-27, 15, -43);
                break;
            case 2405:
                this.transform.position = new Vector3(-27, 15, -33);
                break;
            case 2406:
                this.transform.position = new Vector3(-27, 15, -14);
                break;
            case 2407:
                this.transform.position = new Vector3(-27, 15, -8);
                break;
            case 2408:
                this.transform.position = new Vector3(-27, 15, 0);
                break;
            case 2409:
                this.transform.position = new Vector3(-27, 15, 6);
                break;
            case 2410:
                this.transform.position = new Vector3(-27, 15, 12);
                break;
            case 2411:
                this.transform.position = new Vector3(-27, 15, 19);
                break;
            case 2412:
                this.transform.position = new Vector3(-18, 15, 35);
                break;
            case 2413:
                this.transform.position = new Vector3(-42, 15, 35);
                break;

            // 2-5
            case 2501:
                this.transform.position = new Vector3(-27, 15, -61);
                break;
            case 2502:
                this.transform.position = new Vector3(-27, 15, -47);
                break;
            case 2503:
                this.transform.position = new Vector3(-27, 15, -31);
                break;
            case 2504:
                this.transform.position = new Vector3(-27, 15, -7);
                break;
            case 2505:
                this.transform.position = new Vector3(-27, 15, 4);
                break;
            case 2506:
                this.transform.position = new Vector3(-27, 15, 19);
                break;
            case 2507:
                this.transform.position = new Vector3(-20, 15, 34);
                break;
            case 2508:
                this.transform.position = new Vector3(-43, 15, 34);
                break;

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
                this.transform.position = new Vector3(12, 0, -32);
                break;
            case 5107:
                this.transform.position = new Vector3(12, 0, -42);
                break;
            case 5108:
                this.transform.position = new Vector3(12, 0, -51);
                break;
            case 5109:
                this.transform.position = new Vector3(12, 0, -65);
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
            case 8201:
                this.transform.position = new Vector3(26, 0, -32);
                break;
            case 8202:
                this.transform.position = new Vector3(26, 0, -15);
                break;
            case 8203:
                this.transform.position = new Vector3(26, 0, 3);
                break;
            case 8204:
                this.transform.position = new Vector3(26, 0, 18);
                break;
            case 8205:
                this.transform.position = new Vector3(26, 0, 35);
                break;
            case 8206:
                this.transform.position = new Vector3(26, 0, 51);
                break;
            case 8207:
                this.transform.position = new Vector3(26, 0, 69);
                break;
            case 8208:
                this.transform.position = new Vector3(-20, 0, 51);
                break;
            case 8209:
                this.transform.position = new Vector3(-20, 0, 27);
                break;
            case 8210:
                this.transform.position = new Vector3(-20, 0, -1);
                break;
            case 8211:
                this.transform.position = new Vector3(-20, 0, -1);
                break;
            case 8212:
                this.transform.position = new Vector3(-20, 0, -25);
                break;
            case 8301:
                this.transform.position = new Vector3(28, 0, -34);
                break;
            case 8302:
                this.transform.position = new Vector3(28, 0, -23);
                break;
            case 8303:
                this.transform.position = new Vector3(28, 0, -11);
                break;
            case 8304:
                this.transform.position = new Vector3(28, 0, -1);
                break;
            case 8305:
                this.transform.position = new Vector3(28, 0, 8);
                break;
            case 8306:
                this.transform.position = new Vector3(28, 0, 20);
                break;
            case 8307:
                this.transform.position = new Vector3(28, 0, 32);
                break;
            case 8308:
                this.transform.position = new Vector3(28, 0, 44);
                break;
            case 8309:
                this.transform.position = new Vector3(28, 0, 55);
                break;
            case 8310:
                this.transform.position = new Vector3(22, 0, 64);
                break;
            case 8311:
                this.transform.position = new Vector3(-22, 0, 55);
                break;
            case 8312:
                this.transform.position = new Vector3(-22, 0, 43);
                break;
            case 8313:
                this.transform.position = new Vector3(-22, 0, 32);
                break;
            case 8314:
                this.transform.position = new Vector3(-22, 0, 19);
                break;
            case 8315:
                this.transform.position = new Vector3(-22, 0, 8);
                break;
            case 8316:
                this.transform.position = new Vector3(-22, 0, -2);
                break;
            case 8317:
                this.transform.position = new Vector3(-22, 0, -12);
                break;
            case 8318:
                this.transform.position = new Vector3(-22, 0, -22);
                break;
            case 8319:
                this.transform.position = new Vector3(-22, 0, -33);
                break;
            case 8320:
                this.transform.position = new Vector3(14, 0, -18);
                break;
            case 8321:
                this.transform.position = new Vector3(14, 0, -2);
                break;
            case 8322:
                this.transform.position = new Vector3(14, 0, 13);
                break;
            case 8323:
                this.transform.position = new Vector3(14, 0, 28);
                break;
            case 8324:
                this.transform.position = new Vector3(14, 0, 46);
                break;
            case 8401:
                this.transform.position = new Vector3(28, 0, -34);
                break;
            case 8402:
                this.transform.position = new Vector3(28, 0, -23);
                break;
            case 8403:
                this.transform.position = new Vector3(28, 0, -11);
                break;
            case 8404:
                this.transform.position = new Vector3(28, 0, -1);
                break;
            case 8405:
                this.transform.position = new Vector3(28, 0, 8);
                break;
            case 8406:
                this.transform.position = new Vector3(28, 0, 20);
                break;
            case 8407:
                this.transform.position = new Vector3(28, 0, 32);
                break;
            case 8408:
                this.transform.position = new Vector3(28, 0, 44);
                break;
            case 8409:
                this.transform.position = new Vector3(28, 0, 55);
                break;
            case 8410:
                this.transform.position = new Vector3(22, 0, 64);
                break;
            case 8411:
                this.transform.position = new Vector3(-22, 0, 55);
                break;
            case 8412:
                this.transform.position = new Vector3(-22, 0, 43);
                break;
            case 8413:
                this.transform.position = new Vector3(-22, 0, 32);
                break;
            case 8414:
                this.transform.position = new Vector3(-22, 0, 19);
                break;
            case 8415:
                this.transform.position = new Vector3(-22, 0, 8);
                break;
            case 8416:
                this.transform.position = new Vector3(-22, 0, -2);
                break;
            case 8417:
                this.transform.position = new Vector3(-22, 0, -12);
                break;
            case 8418:
                this.transform.position = new Vector3(-22, 0, -22);
                break;
            case 8419:
                this.transform.position = new Vector3(-22, 0, -33);
                break;
            case 8420:
                this.transform.position = new Vector3(14, 0, -18);
                break;
            case 8421:
                this.transform.position = new Vector3(14, 0, -2);
                break;
            case 8422:
                this.transform.position = new Vector3(14, 0, 13);
                break;
            case 8423:
                this.transform.position = new Vector3(14, 0, 28);
                break;
            case 8424:
                this.transform.position = new Vector3(14, 0, 46);
                break;
            case 8501:
                this.transform.position = new Vector3(27, 0, -31);
                break;
            case 8502:
                this.transform.position = new Vector3(27, 0, -20);
                break;
            case 8503:
                this.transform.position = new Vector3(27, 0, -8);
                break;
            case 8504:
                this.transform.position = new Vector3(27, 0, 3);
                break;
            case 8505:
                this.transform.position = new Vector3(27, 0, 16);
                break;
            case 8506:
                this.transform.position = new Vector3(27, 0, 29);
                break;
            case 8507:
                this.transform.position = new Vector3(27, 0, 42);
                break;
            case 8508:
                this.transform.position = new Vector3(27, 0, 54);
                break;
            case 8509:
                this.transform.position = new Vector3(27, 0, 68);
                break;
            case 8510:
                this.transform.position = new Vector3(-20, 0, 52);
                break;
            case 8511:
                this.transform.position = new Vector3(-20, 0, 26);
                break;
            case 8512:
                this.transform.position = new Vector3(-20, 0, 1);
                break;
            case 8513:
                this.transform.position = new Vector3(-20, 0, -26);
                break;
            case 8601:
                this.transform.position = new Vector3(28, 0, -28);
                break;
            case 8602:
                this.transform.position = new Vector3(28, 0, 8);
                break;
            case 8603:
                this.transform.position = new Vector3(28, 0, 17);
                break;
            case 8604:
                this.transform.position = new Vector3(28, 0, 49);
                break;
            case 8605:
                this.transform.position = new Vector3(28, 0, 68);
                break;
            case 8606:
                this.transform.position = new Vector3(-6, 0, -23);
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
