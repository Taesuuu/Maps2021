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

            //7-3F
            case 7301:
                this.transform.position = new Vector3(12, 0, 31);
                break;
            case 7302:
                this.transform.position = new Vector3(12, 0, 23);
                break;
            case 7303:
                this.transform.position = new Vector3(15, 0, 10);
                break;
            case 7304:
                this.transform.position = new Vector3(15, 0, 0);
                break;
            case 7305:
                this.transform.position = new Vector3(2, 0, -22);
                break;
            case 7306:
                this.transform.position = new Vector3(-11, 0, -24);
                break;
            case 7307:
                this.transform.position = new Vector3(-15, 0, -9);
                break;
            case 7308:
                this.transform.position = new Vector3(-15, 0, 8);
                break;
            case 7309:
                this.transform.position = new Vector3(-15, 0, 24);
                break;
            case 7310:
                this.transform.position = new Vector3(-14, 0, 32);
                break;
            case 7311:
                this.transform.position = new Vector3(-6, 0, 32);
                break;
            case 7312:
                this.transform.position = new Vector3(2, 0, 7);
                break;
            case 7313:
                this.transform.position = new Vector3(2, 0, -9);
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
