using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveDropdown : MonoBehaviour
{

    public List<Dropdown.OptionData> options;
 
    Dropdown dropdown;

    SaveData[] datas;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        datas = SaveSystem.GetFiles();

        Debug.Log("working!");

        for (int i = 0; i < datas.Length; i++)
        {
            Debug.Log(datas[i]);
            dropdown.options.Add(new Dropdown.OptionData(datas[i].dataName));
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
