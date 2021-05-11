using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCam : MonoBehaviour
{
    public bool m = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
            if (Input.GetMouseButtonDown(0) == m)
            {
                this.transform.localScale = new Vector3(2f, 2f, 1f);
                this.transform.position = new Vector3(300f, 600f, 1f);
                m = false;
            }

        else if (m == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.transform.localScale = new Vector3(1f, 1f, 1f);
                this.transform.position = new Vector3(470f, 810f, 1f);
                m = true;
            }
        }


    }
}
