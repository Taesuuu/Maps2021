using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class PlayerGPS : MonoBehaviour
{

    public static double first_Lat; //���� ���� 37.xxx
    public static double first_Long; //���� �浵 126.xxx
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵

    public static double[] A_Lat = new double[20]; // ���� �迭
    public static double[] A_Long = new double[20]; // �浵 �迭 
    public static double Sum_Lat = 0; // ���� �� 
    public static double Sum_Long = 0; // �浵 ��

    public static double YH_Lat = 0; // unity�� ���� (37.xxx)
    public static double YH_Long = 0; // unity�� �浵 (126.xxx)
    public static double YH_Lat_i = 0; // ��
    public static double YH_Lat_d = 0; // ������
    public static double YH_Long_i = 0; // ��
    public static double YH_Long_d = 0; // ������ 

    public TextMeshProUGUI Google_P;
    public TextMeshProUGUI Unity_p; 

    private static WaitForSeconds second;

    private static bool gpsStarted = false;

    private static LocationInfo location;

    private void Awake()
    {
        second = new WaitForSeconds(1.0f);
    }

    IEnumerator Start()
    {
        
        // ������ GPS ��������� ���� üũ
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS is not enabled");
            yield break;
        }

        //GPS ���� ����
        Input.location.Start();
        Debug.Log("Awaiting initialization");

        //Ȱ��ȭ�� �� ���� ���
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return second;
            maxWait -= 1;
        }

        //20�� ������� Ȱ��ȭ �ߴ�
        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }

        //���� ����
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;

        }
        else
        {
            //���� �㰡��, ���� ��ġ ���� �޾ƿ���
            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0d;
            first_Long = location.longitude * 1.0d;
            gpsStarted = true;

            //���� ��ġ ����
            while (gpsStarted)
            {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0d;
                current_Long = location.longitude * 1.0d;
                yield return second;
            }
        }
    }

    //��ġ ���� ����
    public static void StopGPS()
    {
        if (Input.location.isEnabledByUser)
        {
            gpsStarted = false;
            Input.location.Stop();
        }
    }
    /*
    private void Update()
    {
        for(int i = 0;i < 20; i++)
        {
            A_Lat[i] = current_Lat;
            Sum_Lat = A_Lat[i]; 
        }

        for(int i = 0; i < 20; i++)
        {
            A_Long[i] = current_Long;
            Sum_Long = A_Long[i];
        }

        YHGPS();
    }

    public void YHGPS()
    {
        YH_Lat_i = Sum_Lat * 190 / 0.00194;
        YH_Lat_d = Sum_Long * 190 % 0.00194;
        YH_Lat = YH_Lat_i + YH_Lat_d;

        YH_Long_i = Sum_Long * 250 / 0.00255;
        YH_Long_d = Sum_Long * 250 % 0.00255;
        YH_Long = YH_Long_i + YH_Long_d;

        this.transform.position = new Vector3((float)YH_Lat, 0, (float)YH_Long);

        Google_P.text = "Lat : " + Sum_Lat.ToString() + ", Long : " + Sum_Long.ToString() + "c Lat :" + current_Lat.ToString() + "c Long :" + current_Long.ToString();
        Unity_p.text = "Unity Lat : " + YH_Lat.ToString() + ", Unity Long : " + YH_Long.ToString();
    }
    */
}
