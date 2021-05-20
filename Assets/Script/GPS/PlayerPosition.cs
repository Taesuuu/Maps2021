using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerPosition : MonoBehaviour, IPointerDownHandler
{
    public Camera cam;
    public GameObject Player;

    public RaycastHit hit;

    public void OnPointerDown(PointerEventData eventData)
    {
        Ray ray = cam.ScreenPointToRay(eventData.position);
        Physics.Raycast(ray, out hit);

        Player.transform.position = hit.point;
    }
}
