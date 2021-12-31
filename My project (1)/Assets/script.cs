using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{

    public Text TextBox;

    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();
        
        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Item 1");
        items.Add("Item 2");

        foreach (var item in items) {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
    }
}