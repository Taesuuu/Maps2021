using System.Collections;
using UnityEngine;

public class PlayerGPS : MonoBehaviour
{

    public static double first_Lat; //최초 위도
    public static double first_Long; //최초 경도
    public static double current_Lat; //현재 위도
    public static double current_Long; //현재 경도

    public double YH_Lat = 0; // unity상 위도 (37.xxx)
    public double YH_Long = 0; // unity상 경도 (126.xxx)
    public double YH_Lat_i = 0; // 몫
    public double YH_Lat_d = 0; // 나머지
    public double YH_Long_i = 0; // 몫
    public double YH_Long_d = 0; // 나머지 

    private static WaitForSeconds second;

    private static bool gpsStarted = false;

    private static LocationInfo location;

    private void Awake()
    {
        second = new WaitForSeconds(1.0f);
    }

    IEnumerator Start()
    {
        
        // 유저가 GPS 사용중인지 최초 체크
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS is not enabled");
            yield break;
        }

        //GPS 서비스 시작
        Input.location.Start();
        Debug.Log("Awaiting initialization");

        //활성화될 때 까지 대기
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return second;
            maxWait -= 1;
        }

        //20초 지날경우 활성화 중단
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        //연결 실패
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;

        }
        else
        {
            //접근 허가됨, 최초 위치 정보 받아오기
            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0d;
            first_Long = location.longitude * 1.0d;
            gpsStarted = true;

            //현재 위치 갱신
            while (gpsStarted)
            {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0d;
                current_Long = location.longitude * 1.0d;
                yield return second;
            }
        }
    }
    public void YHGPS()
    {
        YH_Lat_i  = current_Lat * 190 / 0.00194;
        YH_Lat_d = current_Lat * 190 % 0.00194;
        YH_Lat = YH_Lat_i + YH_Lat_d;

        YH_Long_i = current_Long * 250 / 0.00255;
        YH_Long_d = current_Long * 350 % 0.00255;
        YH_Long = YH_Long_i + YH_Long_d;
    }

    //위치 서비스 종료
    public static void StopGPS()
    {
        if (Input.location.isEnabledByUser)
        {
            gpsStarted = false;
            Input.location.Stop();
        }
    }
}
