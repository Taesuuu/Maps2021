using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGPS : MonoBehaviour
{
    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public GameObject Building4;
    public GameObject Building5;
    public GameObject Building6;
    public GameObject Building7;
    public GameObject Building8;
    public GameObject Door;

    private double[] Lat;
    private double[] Long;

//    public static double B1_Lat;
//    public static double B1_Long; 
    public static double f_Lat; //비율 경도
    public static double f_Long; //비율 경도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuildingMap()
    {
        for(int i =0; i<8; i++)
        {
            //    f_Lat = (Lat - 37.48747) * 100000;
            //    f_Long = (Long - 126.81980) * 100000;
        }


        if (f_Lat < 0)
        {
            f_Lat = f_Lat * (-1);
        }
        if (f_Long < 0)
        {
            f_Long = f_Long * (-1);
        }


    //    .transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
    }
}

