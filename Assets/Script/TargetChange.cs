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
