using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexNum : MonoBehaviour
{
    public static IndexNum indexsNum;
    public int numIndex;

    private void Awake()
    {
        indexsNum = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
