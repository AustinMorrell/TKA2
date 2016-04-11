using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Xml.Serialization;

[Serializable]
public class CandyCat : MonoBehaviour {

    [SerializeField]
    private Player Cat;

    public void OnClick()
    {
        Save();
        SceneManager.LoadScene("Choose-Map");
    }

    public void Save()
    {
        // I make the path to the file.
        var path = Environment.CurrentDirectory + "\\SaveData.xml";
        // Make the file.
        System.IO.FileStream file = System.IO.File.Create(path);
        // Write to the file.
        XmlSerializer writer = new XmlSerializer(Cat.GetType());
        writer.Serialize(file, Cat);
        // And then close the file.
        file.Close();
    }
}
