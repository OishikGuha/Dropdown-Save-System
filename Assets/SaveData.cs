using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{   
    public string sentence;
    public string dataName;

    public SaveData(SaveInput input)
    {
        dataName = input.name;
        sentence = input.sentence;
    }
}
