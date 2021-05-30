using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveSystem 
{

    public static string mainPath = Application.persistentDataPath;

    public static void Save(SaveInput input)
    {
        Debug.Log(input.name);
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + input.name;
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(input);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SaveData[] GetFiles()
    {

        List<SaveData> dataList = new List<SaveData>();
        string[] rawData = Directory.GetFiles(mainPath, "*", SearchOption.AllDirectories);

        Debug.Log(rawData.Length);

        for (int i = 0; i < rawData.Length; i++)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            
            rawData[i] = rawData[i].Replace('/', '\\');
            Debug.Log(rawData[i]);

            FileStream stream = new FileStream(rawData[i], FileMode.Open);
            stream.Position = 0;

            SaveData data = formatter.Deserialize(stream) as SaveData;

            dataList.Add(data); 
        }

        return dataList.ToArray();
    }
}
