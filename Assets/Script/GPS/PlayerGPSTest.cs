using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PlayerGPSTest : MonoBehaviour
{

    static bool gpsInit = false;
    LocationInfo currentGPSPosition; // ��ġ �޾ƿ��� 
    int gps_connect = 0;
   
    double detailed_num = 1.0;//���� ��ǥ�� float������ �Ҽ��� �ڸ��� ���� �ڼ��� ��µǴ� double�� ���Ͽ� �ڼ��� ���� ���մϴ�.
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵
    public static double f_Lat; //���� �浵
    public static double f_Long; //���� �浵

    public static double[] A_Lat = new double[20]; // ���� �迭
    public static double[] A_Long = new double[20]; // �浵 �迭 
    public static double Sum_Lat = 0; // ���� �� 
    public static double Sum_Long = 0; // �浵 ��

    public static double Sum_Lat_i = 0; // ���� �� / 20
    public static double Sum_Lat_d = 0; // ���� �� % 20
    public static double Sum_Long_i = 0; // �浵 �� / 20
    public static double Sum_Long_d = 0; // �浵 �� % 20

    public static double Sum_Lat_F = 0; // ���� �� 
    public static double Sum_Long_F = 0; // �浵 ��

    public static double YH_Lat = 0; // unity�� ���� (37.xxx)
    public static double YH_Long = 0; // unity�� �浵 (126.xxx)
    public static double YH_Lat_i = 0; // ��
    public static double YH_Lat_d = 0; // ������
    public static double YH_Long_i = 0; // ��
    public static double YH_Long_d = 0; // ������ 

    public Text google_map; // ����
    public Text sum_map; // �迭 
    public Text unity_map; // ����Ƽ
 //   public Text text_FLat; // �������� ����
 //  public Text text_FLong; // �������� �浵 



 //   public GameObject Player;
   // public Text text_refresh;

    // Use this for initialization

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
        else//GPS�� ���� ��� (GPS�� ���� ���ų� �ȵ���̵� GPS�� ���� ���� �ʾ��� ���
        {
  //          text_latitude.text = "GPS not available";
  //          text_longitude.text = "GPS not available";
        }
    }

    void RetrieveGPSData()
    {
        currentGPSPosition = Input.location.lastData;//gps�� �����͸� �޽��ϴ�.

        current_Lat = currentGPSPosition.latitude * detailed_num;
        current_Long = currentGPSPosition.longitude * detailed_num;

        google_map.text = "c Lat :" + current_Lat.ToString() + "c Long :" + current_Long.ToString(); 

        //        text_latitude.text = "���� " + current_Lat.ToString();//���� ���� �޾�,�ؽ�Ʈ�� ����մϴ�
        //       text_longitude.text = "�浵 " + current_Long.ToString();//�浵 ���� �޾�, �ؽ�Ʈ�� ����մϴ�.

        gps_connect++;

       // text_refresh.text = "���� Ƚ�� : " + gps_connect.ToString();
    }

 /*     public void Map() // ������ �ٲٱ� 
    {
        f_Lat = (current_Lat - 37.48747) * 100000;
        f_Long = (current_Long - 126.81980) * 100000;

        // ���� -> ��� 
              if (f_Lat < 0)
               {
                   f_Lat = f_Lat * (-1);
               }

               if (f_Long < 0)
               {
                   f_Long = f_Long * (-1);
               }
        
            Player.transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
        text_FLong.text = "�������� �浵 " + (current_Lat - 37.48747).ToString();//�浵 ���� �޾�, �ؽ�Ʈ�� ����մϴ�.

        text_FLat.text = "�������� ���� " + f_Lat.ToString();//���� ���� �޾�,�ؽ�Ʈ�� ����մϴ�.
        text_FLong.text = "�������� �浵 " + f_Long.ToString();//�浵 ���� �޾�, �ؽ�Ʈ�� ����մϴ�.
    }
*/
    private void Update()
    {
        for (int i = 0; i < 20; i++)
        {
            A_Lat[i] = current_Lat;
            A_Lat[i] = A_Lat[i] - 37.48808; // �Ÿ����ϱ� 
            Sum_Lat += A_Lat[i]; // 20�� ���ϱ� 
        }
        Sum_Lat_i = Sum_Lat / 20; // ��ձ��ϱ� int
        Sum_Lat_d = Sum_Lat % 20; // double 
        Sum_Lat_F = Sum_Lat_i + Sum_Lat_d; 

        for (int i = 0; i < 20; i++)
        {
            A_Long[i] = current_Long;
            A_Long[i] = A_Long[i] - 126.81970;
            Sum_Long += A_Long[i];
        }
        Sum_Long_i = Sum_Long / 20;
        Sum_Long_d = Sum_Long % 20;
        Sum_Long_F = Sum_Long_i + Sum_Long_d; 

        YHGPS();
    }
    public void YHGPS()
    {
        YH_Lat_i = Sum_Lat_F * 190 / 0.00194;
        YH_Lat_d = Sum_Long_F * 190 % 0.00194;
        YH_Lat = YH_Lat_i + YH_Lat_d;

        YH_Long_i = Sum_Long * 250 / 0.00255;
        YH_Long_d = Sum_Long * 250 % 0.00255;
        YH_Long = YH_Long_i + YH_Long_d;

        this.transform.position = new Vector3((float)YH_Lat, 0, (float)YH_Long);

        sum_map.text = "s_Lat : " + Sum_Lat_F.ToString() + ", s_Long : " + Sum_Long_F.ToString() + " a_lat" + A_Lat[1].ToString() + " a_long: " + A_Long[1].ToString();
        unity_map.text = "Unity Lat : " + YH_Lat.ToString() + ", Unity Long : " + YH_Long.ToString();
    }
}