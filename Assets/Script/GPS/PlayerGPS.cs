using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        // ?????? GPS ?????????? ???? ????
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

        //20?? ???????? ?????? ????
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        //???? ????
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;

        }
        else
        {
            //???? ??????, ???? ???? ???? ????????
            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0f;
            first_Long = location.longitude * 1.0f;
            gpsStarted = true;

            //???? ???? ????
            while (gpsStarted)
            {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0f;
                current_Long = location.longitude * 1.0f;
                yield return second;
            }
        }
    }

    public void Map()
    {
        // ???? ???? ???? 
        f_Lat = (float)((current_Lat - 37.48747) * 100000);
        f_Long = (float)(current_Long - 126.81980) * 100000;
    
        // ???? ?????? ????
    //    f_Lat = (float)((current_Lat - 37.42645) * 10000); 
    //    f_Long = (float)(current_Long - 126.99186) * 10000;


        if (f_Lat < 0)
        {
            f_Lat = f_Lat * (-1); 
        }
        if (f_Long < 0)
        {
            f_Long = f_Long * (-1);
        }

    }

    void Update()
    {
    //    this.transform.position = new Vector3(10, 0, 10);
        this.transform.position = new Vector3(f_Lat, 0, f_Long);
        xText.text = "X : " + f_Lat.ToString();
        yText.text = "Y : " + f_Long.ToString();

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