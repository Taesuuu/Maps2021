using System.Collections;
using UnityEngine;

public class PlayerGPS : MonoBehaviour
{

    public static double first_Lat; //���� ����
    public static double first_Long; //���� �浵
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵

    public double YH_Lat = 0; // unity�� ���� (37.xxx)
    public double YH_Long = 0; // unity�� �浵 (126.xxx)
    public double YH_Lat_i = 0; // ��
    public double YH_Lat_d = 0; // ������
    public double YH_Long_i = 0; // ��
    public double YH_Long_d = 0; // ������ 

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
    public void YHGPS()
    {
        YH_Lat_i  = current_Lat * 190 / 0.00194;
        YH_Lat_d = current_Lat * 190 % 0.00194;
        YH_Lat = YH_Lat_i + YH_Lat_d;

        YH_Long_i = current_Long * 250 / 0.00255;
        YH_Long_d = current_Long * 350 % 0.00255;
        YH_Long = YH_Long_i + YH_Long_d;
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
}
