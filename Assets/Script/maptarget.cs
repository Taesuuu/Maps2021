using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maptarget : MonoBehaviour
{
    public static int gogo;

    // Start is called before the first frame update
    void Start()
    {
        switch (gogo)
        {
            case 1:
                this.transform.position = new Vector3(135, 0, -57);
                break;
            case 2:
                this.transform.position = new Vector3(96, 0, -9);
                break;
            case 3:
                this.transform.position = new Vector3(84, 0, -104);
                break;
            case 4:
                this.transform.position = new Vector3(186, 0, -10);
                break;
            case 5:
                this.transform.position = new Vector3(179, 0, -60);
                break;
            case 6:
                this.transform.position = new Vector3(192, 0, -60);
                break;
            case 7:
                this.transform.position = new Vector3(186, 0, -145);
                break;
            case 8:
                this.transform.position = new Vector3(102, 0, -152);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
