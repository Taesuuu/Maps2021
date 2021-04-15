using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PlayerGPSTest : MonoBehaviour
{

    bool gpsInit = false;
    LocationInfo currentGPSPosition; // ��ġ �޾ƿ��� 
    int gps_connect = 0;
   
    double detailed_num = 1.0;//���� ��ǥ�� float������ �Ҽ��� �ڸ��� ���� �ڼ��� ��µǴ� double�� ���Ͽ� �ڼ��� ���� ���մϴ�.
    public static double current_Lat; //���� ����
    public static double current_Long; //���� �浵
    public static double f_Lat; //���� �浵
    public static double f_Long; //���� �浵

    public Text text_latitude; // ����
    public Text text_longitude; // �浵 
    public Text text_FLat; // �������� ����
    public Text text_FLong; // �������� �浵 

    public GameObject Player;
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
            text_latitude.text = "GPS not available";
            text_longitude.text = "GPS not available";
        }
    }

    void RetrieveGPSData()
    {
        currentGPSPosition = Input.location.lastData;//gps�� �����͸� �޽��ϴ�.

        current_Lat = currentGPSPosition.latitude * detailed_num;
        current_Long = currentGPSPosition.longitude * detailed_num;

        text_latitude.text = "���� " + current_Lat.ToString();//���� ���� �޾�,�ؽ�Ʈ�� ����մϴ�
        text_longitude.text = "�浵 " + current_Long.ToString();//�浵 ���� �޾�, �ؽ�Ʈ�� ����մϴ�.

        gps_connect++;

       // text_refresh.text = "���� Ƚ�� : " + gps_connect.ToString();
    }

    public void Map() // ������ �ٲٱ� 
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

        text_FLat.text = "���� " + f_Lat.ToString();//���� ���� �޾�,�ؽ�Ʈ�� ����մϴ�.
        text_FLong.text = "�浵 " + f_Long.ToString();//�浵 ���� �޾�, �ؽ�Ʈ�� ����մϴ�.
    }
}