using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PlayerGPSTest : MonoBehaviour
{

    static bool gpsInit = false;
    LocationInfo currentGPSPosition; // 위치 받아오기 
    int gps_connect = 0;
   
    double detailed_num = 1.0;//기존 좌표는 float형으로 소수점 자리가 비교적 자세히 출력되는 double을 곱하여 자세한 값을 구합니다.
    public static double current_Lat; //현재 위도
    public static double current_Long; //현재 경도
    public static double f_Lat; //비율 경도
    public static double f_Long; //비율 경도

    public static double[] A_Lat = new double[20]; // 위도 배열
    public static double[] A_Long = new double[20]; // 경도 배열 
    public static double Sum_Lat = 0; // 위도 합 
    public static double Sum_Long = 0; // 경도 합

    public static double Sum_Lat_i = 0; // 위도 합 / 20
    public static double Sum_Lat_d = 0; // 위도 합 % 20
    public static double Sum_Long_i = 0; // 경도 합 / 20
    public static double Sum_Long_d = 0; // 경도 합 % 20

    public static double Sum_Lat_F = 0; // 위도 합 
    public static double Sum_Long_F = 0; // 경도 합

    public static double YH_Lat = 0; // unity상 위도 (37.xxx)
    public static double YH_Long = 0; // unity상 경도 (126.xxx)
    public static double YH_Lat_i = 0; // 몫
    public static double YH_Lat_d = 0; // 나머지
    public static double YH_Long_i = 0; // 몫
    public static double YH_Long_d = 0; // 나머지 

    public Text google_map; // 구글
    public Text sum_map; // 배열 
    public Text unity_map; // 유니티
 //   public Text text_FLat; // 비율적용 위도
 //  public Text text_FLong; // 비율적용 경도 



 //   public GameObject Player;
   // public Text text_refresh;

    // Use this for initialization

    void Start()

    {

        Input.location.Start(0.5f);

        int wait = 1000; // 기본 값
        // Checks if the GPS is enabled by the user (-> Allow location ) 

        if (Input.location.isEnabledByUser)//사용자에 의하여 좌표값을 실행 할 수 있을 경우
        {
            while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)//초기화 진행중이면
            {
                wait--; // 기다리는 시간을 뺀다
            }

            //GPS를 잡는 대기시간
            if (Input.location.status != LocationServiceStatus.Failed)//GPS가 실행중이라면
            {
                gpsInit = true;
                // We start the timer to check each tick (every 3 sec) the current gps position
                InvokeRepeating("RetrieveGPSData", 0.0001f, 1.0f);//0.0001초에 실행하고 1초마다 해당 함수를 실행합니다.
            }
        }
        else//GPS가 없는 경우 (GPS가 없는 기기거나 안드로이드 GPS를 설정 하지 않았을 경우
        {
  //          text_latitude.text = "GPS not available";
  //          text_longitude.text = "GPS not available";
        }
    }

    void RetrieveGPSData()
    {
        currentGPSPosition = Input.location.lastData;//gps를 데이터를 받습니다.

        current_Lat = currentGPSPosition.latitude * detailed_num;
        current_Long = currentGPSPosition.longitude * detailed_num;

        google_map.text = "c Lat :" + current_Lat.ToString() + "c Long :" + current_Long.ToString(); 

        //        text_latitude.text = "위도 " + current_Lat.ToString();//위도 값을 받아,텍스트에 출력합니다
        //       text_longitude.text = "경도 " + current_Long.ToString();//경도 값을 받아, 텍스트에 출력합니다.

        gps_connect++;

       // text_refresh.text = "갱신 횟수 : " + gps_connect.ToString();
    }

 /*     public void Map() // 비율로 바꾸기 
    {
        f_Lat = (current_Lat - 37.48747) * 100000;
        f_Long = (current_Long - 126.81980) * 100000;

        // 음수 -> 양수 
              if (f_Lat < 0)
               {
                   f_Lat = f_Lat * (-1);
               }

               if (f_Long < 0)
               {
                   f_Long = f_Long * (-1);
               }
        
            Player.transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
        text_FLong.text = "비율적용 경도 " + (current_Lat - 37.48747).ToString();//경도 값을 받아, 텍스트에 출력합니다.

        text_FLat.text = "비율적용 위도 " + f_Lat.ToString();//위도 값을 받아,텍스트에 출력합니다.
        text_FLong.text = "비율적용 경도 " + f_Long.ToString();//경도 값을 받아, 텍스트에 출력합니다.
    }
*/
    private void Update()
    {
        for (int i = 0; i < 20; i++)
        {
            A_Lat[i] = current_Lat;
            A_Lat[i] = A_Lat[i] - 37.48808; // 거리구하기 
            Sum_Lat += A_Lat[i]; // 20개 더하기 
        }
        Sum_Lat_i = Sum_Lat / 20; // 평균구하기 int
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