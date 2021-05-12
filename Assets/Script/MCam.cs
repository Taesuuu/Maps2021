using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCam : MonoBehaviour
{
    public bool m = true;
    RectTransform pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = GetComponent<RectTransform>();
        pos.anchoredPosition = new Vector3(-102, -102, 0);

        if (Input.GetMouseButtonDown(0) == m)
            {
                this.transform.localScale = new Vector3(2f, 2f, 1f);
               pos.anchoredPosition = new Vector3(-200, -200, 0);
            m = false;
        }

        else if (m == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.transform.localScale = new Vector3(1f, 1f, 1f);
                pos.anchoredPosition = new Vector3(-102, -102, 0);
                m = true;
            }
        }


    }
}
