using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

public class PlayerGPSTest : MonoBehaviour
{
    static bool gpsInit = false;
    LocationInfo currentGPSPosition; // ��ġ �޾ƿ��� 
   
    double detailed_num = 1.0;//���� ��ǥ�� float������ �Ҽ��� �ڸ��� ���� �ڼ��� ��µǴ� double�� ���Ͽ� �ڼ��� ���� ���մϴ�.
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵

    public double[] Ar_Lat = new double[20]; // ���� �迭
    public double[] Ar_Long = new double[20]; // �浵 �迭 
    public static float Sum_Lat = 0; // ���� �� 
    public static float Sum_Long = 0; // �浵 ��

    public static double Average_Lat_F = 0; // ���� �� 
    public static double Average_Long_F = 0; // �浵 ��

    public static double YH_Lat = 0; // unity�� ���� (37.xxx)
    public static double YH_Long = 0; // unity�� �浵 (126.xxx)
    public static double YH_Lat_i = 0; // ��
    public static double YH_Lat_d = 0; // ������
    public static double YH_Long_i = 0; // ��
    public static double YH_Long_d = 0; // ������ 

    public Text google_map; // ����
    public Text sum_map; // �迭 
    public Text unity_map; // ����Ƽ
    public Text array_check; // �迭 Ȯ��  

    void Start()
    {
        Input.location.Start(0.5f);

        int wait = 1000; // �⺻ ��
        // Checks if the GPS is enabled by the user (-> Allow location ) 

        if (Input.location.isEnabledByUser)//����ڿ� ���Ͽ� ��ǥ���� ���� �� �� ���� ���
        {
            while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)//�ʱ�ȭ �������̸�
            {
                wait--; // ��ٸ��� �ð��� ����
            }

            //GPS�� ��� ���ð�
            if (Input.location.status != LocationServiceStatus.Failed)//GPS�� �������̶��
            {
                gpsInit = true;
                // We start the timer to check each tick (every 3 sec) the current gps position
                InvokeRepeating("RetrieveGPSData", 0.0001f, 1.0f);//0.0001�ʿ� �����ϰ� 1�ʸ��� �ش� �Լ��� �����մϴ�.
            }
        }
        else //GPS�� ���� ��� (GPS�� ���� ���ų� �ȵ���̵� GPS�� ���� ���� �ʾ��� ���
        {
            google_map.text = "GPS not available";
            google_map.text = "GPS not available";
        }
    }

    void RetrieveGPSData()
    {
        currentGPSPosition = Input.location.lastData;//gps�� �����͸� �޽��ϴ�.

        current_Lat = currentGPSPosition.latitude * detailed_num;
        current_Long = currentGPSPosition.longitude * detailed_num;

        google_map.text = "c Lat :" + current_Lat.ToString() + "c Long :" + current_Long.ToString();

        for (int i = 0; i < 20; i++)
        {
            Ar_Lat[i] = current_Lat;
            Ar_Lat[i] = (Ar_Lat[i] - 37.48808); // �Ÿ����ϱ� 
          //  Sum_Lat += A_Lat[i]; // 20�� ���ϱ� 
        }
        Average_Lat_F = Ar_Lat.Average();

        for (int i = 0; i < 20; i++)
        {
            Ar_Long[i] = current_Long;
            Ar_Long[i] = (Ar_Long[i] - 126.81970);
        //    Sum_Long += Ar_Long[i];
        }
        Average_Long_F = Ar_Long.Average(); 
    }
  
    private void Update()
    {
        YHGPS();
    }

    public void YHGPS()
    {
     //   YH_Lat_i = (Average_Lat_F * 190 / 0.00194);
     //   YH_Lat_d = (Average_Long_F * 190 % 0.00194);
        YH_Lat = (Average_Lat_F * 190 / 0.00194);

     //   YH_Long_i =(Sum_Long * 250 / 0.00255);
     //   YH_Long_d =(Sum_Long * 250 % 0.00255);
        YH_Long = (Average_Long_F * 250 / 0.00255);

        this.transform.position = new Vector3((float)YH_Long, 0, (float)YH_Lat);

        array_check.text = " a_lat_0 : " + Ar_Lat[0].ToString() + " a_long_0 : " + Ar_Long[0].ToString() +
                           " a_lat_1 : " + Ar_Lat[1].ToString() + " a_long_1 : " + Ar_Long[1].ToString() +
                           " a_lat_2 : " + Ar_Lat[2].ToString() + " a_long_2 : " + Ar_Long[2].ToString() +
                           " a_lat_3 : " + Ar_Lat[3].ToString() + " a_long_3 : " + Ar_Long[3].ToString() +
                           " a_lat_4 : " + Ar_Lat[4].ToString() + " a_long_4 : " + Ar_Long[4].ToString() +
                           " a_lat_5 : " + Ar_Lat[5].ToString() + " a_long_5 : " + Ar_Long[5].ToString() +
                           " a_lat_6 : " + Ar_Lat[6].ToString() + " a_long_6 : " + Ar_Long[6].ToString() +
                           " a_lat_7 : " + Ar_Lat[7].ToString() + " a_long_7 : " + Ar_Long[7].ToString() +
                           " a_lat_8 : " + Ar_Lat[8].ToString() + " a_long_8 : " + Ar_Long[8].ToString() +
                           " a_lat_9 : " + Ar_Lat[9].ToString() + " a_long_9 : " + Ar_Long[9].ToString() +
                           " a_lat_10 : " + Ar_Lat[10].ToString() + " a_long_10 : " + Ar_Long[10].ToString() +
                           " a_lat_11 : " + Ar_Lat[11].ToString() + " a_long_11 : " + Ar_Long[11].ToString() +
                           " a_lat_12 : " + Ar_Lat[12].ToString() + " a_long_12 : " + Ar_Long[12].ToString() +
                           " a_lat_13 : " + Ar_Lat[13].ToString() + " a_long_13 : " + Ar_Long[13].ToString() +
                           " a_lat_14 : " + Ar_Lat[14].ToString() + " a_long_14 : " + Ar_Long[14].ToString() +
                           " a_lat_15 : " + Ar_Lat[15].ToString() + " a_long_15 : " + Ar_Long[15].ToString() +
                           " a_lat_16 : " + Ar_Lat[16].ToString() + " a_long_16 : " + Ar_Long[16].ToString() +
                           " a_lat_17 : " + Ar_Lat[17].ToString() + " a_long_17 : " + Ar_Long[17].ToString() +
                           " a_lat_18 : " + Ar_Lat[18].ToString() + " a_long_18 : " + Ar_Long[18].ToString() +
                           " a_lat_19 : " + Ar_Lat[19].ToString() + " a_long_19 : " + Ar_Long[19].ToString();
      
        sum_map.text = "s_Lat : " + Average_Lat_F.ToString() + ", s_Long : " + Average_Long_F.ToString();
        unity_map.text = "Unity Lat : " + YH_Lat.ToString() + ", Unity Long : " + YH_Long.ToString() +
                         "\n(float)Unity_Long : " + (float)YH_Long + ", (float)Unity_Lat : " + (float)YH_Lat +
                         "\n (x, z) : (" + this.transform.position.x + ", " + this.transform.position.z + ")";
    }
}