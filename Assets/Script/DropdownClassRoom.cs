using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropdownClassRoom : MonoBehaviour
{
    public Text TextBox;
    public int getValue;
    internal static readonly object getValiue;

    private void Start()
    {
        DontDestroyOnLoad(this);
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("7201");
        items.Add("7202");
        items.Add("7203");
        items.Add("7204");
        items.Add("7205");
        items.Add("7206");
        items.Add("7207");
        items.Add("7208");
        items.Add("7209");
        items.Add("7210");
        items.Add("7211");
        items.Add("7212");
        items.Add("7213");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });


        

    }
    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        TextBox.text = dropdown.options[index].text;
        getValue = int.Parse(dropdown.options[index].text);
        IndexNum.indexsNum.numIndex = getValue;
        
    }
    private void Update()
    {
        
        Debug.Log(getValue);
    }
    
}
