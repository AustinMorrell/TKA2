using UnityEngine;
using System.Collections;
using System;
using System.Xml.Serialization;

public class SaveLoad : MonoBehaviour
{
    [SerializeField]
    GameCon GC;

	void Awake()
    {
        //Save();
        //Load();
    }

    public void Save()
    {
        // I make the path to the file.
        var path = Environment.CurrentDirectory + "\\SaveData.xml";
        // Make the file.
        System.IO.FileStream file = System.IO.File.Create(path);
        // Write to the file.
        XmlSerializer writer = new XmlSerializer(GC.GetType());
        writer.Serialize(file, GC);
        // And then close the file.
        file.Close();
    }

    public void Load()
    {
        // I make the path to the file.
        var path = Environment.CurrentDirectory + "\\SaveData.xml";
        // Make the deserializer.
        XmlSerializer serializer = new XmlSerializer(typeof(GameCon));
        // Make the reader for the file.
        System.IO.StreamReader reader = new System.IO.StreamReader(path);
        // Read and deserialize the file.
        GC = (GameCon)serializer.Deserialize(reader);
        // Close the reader.
        reader.Close();
    }
}
