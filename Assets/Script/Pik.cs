using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
}
