using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropC : MonoBehaviour
{
    public Text TextBox;
    public int getFloor;

    private void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("1층");
        items.Add("2층");
        items.Add("3층");
        items.Add("4층");
        items.Add("5층");
        items.Add("6층");

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
       // getFloor = int.Parse(dropdown.options[index].text);
    }
    private void Update()
    {
        
    }
}
