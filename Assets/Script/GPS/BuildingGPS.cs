using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGPS : MonoBehaviour
{
    //    public GameObject Building1;
    //    public GameObject Building2;
    //    public GameObject Building3;
    //    public GameObject Building4;
    //    public GameObject Building5;
    //    public GameObject Building6;
    //    public GameObject Building7;
    //    public GameObject Building8;
    //    public GameObject Door;
    public GameObject[] Building; // �ǹ� �迭_ [0] == ���� [1] == 1ȣ��
    private double[] B_Lat; // Building �迭 �浵 
    private double[] B_Long; // Building �迭 ����
    int i;
    //    public static double B1_Lat;
    //    public static double B1_Long; 
    public static double f_Lat; //���� �浵
    public static double f_Long; //���� �浵

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
        for (i = 0; i < Building.Length; i++) // �ǹ� �޾ƿ��� 
        {
            
            f_Lat = (B_Lat[i] - 37.48747) * 100000;
            f_Long = (B_Long[i] - 126.81980) * 100000;
            if (f_Lat < 0)
            {
                f_Lat = f_Lat * (-1);
            }
            if (f_Long < 0)
            {
                f_Long = f_Long * (-1);
            }

            Building[i].transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
            //    f_Lat = (Lat - 37.48747) * 100000;
            //    f_Long = (Long - 126.81980) * 100000;
        }


       


    //    .transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
    }
}

