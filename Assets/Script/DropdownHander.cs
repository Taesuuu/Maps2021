using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHander : MonoBehaviour
{
    public Text TextBox;
    

    public int getBuil;
    

    private void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("1.평화관");
        items.Add("2.봉사관");
        items.Add("3.자유관");
        items.Add("4.학생회관");
        items.Add("5.나눔관");
        items.Add("6.창조관");
        items.Add("7.유일한기념관");
        items.Add("8.유재라관");

        foreach(var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
        
    }
    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        TextBox.text = dropdown.options[index].text;
        
        
        //getBuil = int.Parse(dropdown.options[index].text);

    }
    private void Update()
    {
        
    }
}
