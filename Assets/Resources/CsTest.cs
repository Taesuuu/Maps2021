using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Dictionary<string, object>> da = CSVReader.Read("cs2");

        for(int i =0; i < da.Count; i++)
        {
            print(da[i]["평화관이"].ToString());

            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
