using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInput : MonoBehaviour
{

    public new string name;
    public string sentence;

    public InputField nameField;
    
    InputField input;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        name = nameField.text;
        sentence = input.text;
    }

    public void Save()
    {
        SaveSystem.Save(this);
    }
}
