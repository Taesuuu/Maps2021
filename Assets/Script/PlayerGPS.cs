using System.Collections;
using UnityEngine;

public class PlayerGPS : MonoBehaviour
{

    public Text xText;
    public Text yText;

    public static float first_Lat; //???? ????
    public static float first_Long; //???? ????
    public static float current_Lat; //???? ????
    public static float current_Long; //???? ????
    public static float f_Lat; //???? ????
    public static float f_Long; //???? ????
    
    public GameObject player; // ???????? 

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

        //GPS ?????? ????
        Input.location.Start();
        Debug.Log("Awaiting initialization");

        //???????? ?? ???? ????
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

    public void Map()
    {
        f_Lat = (current_Lat - 37.48747) * 100000;
        f_Long = (current_Long - 126.81980) * 100000;
       
        if(f_Lat < 0)
        {
            f_Lat = f_Lat * (-1); 
        }
        if (f_Long < 0)
        {
            f_Long = f_Long * (-1);
        }


        player.transform.position = new Vector3((float)f_Lat, 0, (float)f_Long);
    }

    //???? ?????? ????
    public static void StopGPS()
    {
        if (Input.location.isEnabledByUser)
        {
            gpsStarted = false;
            Input.location.Stop();
        }
    }
}