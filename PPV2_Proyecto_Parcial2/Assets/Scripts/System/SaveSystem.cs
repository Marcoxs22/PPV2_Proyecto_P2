using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public float PosX;
    public float PosY;
    public float PosZ;
    public static SaveSystem instance;
    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        //SaveToJSON("LecciónDunny", data);
        //SaveToJSON("SubjectDunny", subject);

        CreateFile("Marco position", ".data");
        Debug.Log(ReadFile("Marco position", ".data"));
        //Subject = LoadFromJSON<SubjectContainer>("SubjectDunny");
    }



    //public void CreateFile(string fileName, string extension)
    //{

    //}

    //public void SaveToJSON(string _fileName, object _data)
    //{

    //}

    public void CreateFile(string _name, string _extension)
    {
        //1 Definir el path del archivo
        string path = Application.dataPath + "/" + _name + _extension;
        //2 Revisamos, si, el archivo en el path NO existe
        if (!File.Exists(path))
        {
            //3 Creamos el contenido 
            string content = "Login Date: " + System.DateTime.Now + "/n";
            string position = "x: " + gameObject.transform.position.x + 
                ", y: " + gameObject.transform.position.y;
            //4 Alamacenamos la información 
            File.AppendAllText(path, position);
        }
        else
        {
            Debug.LogWarning("Atención: Estás tratando de crear un archivo con el mismo nombre [" 
                + _name + _extension + "], verifica tu información");
        }
    }

    string ReadFile(string _fileName, string _extension)
    {
        //1 Acceder al Path del archivo
        string path = Application.dataPath + "/Resources/" + _fileName + _extension;

        //2 Si el archivo existe, dame su info
        string data = " ";
        if (File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
        return data;    
    }

    public void SaveToJSON(string _fileName, object _data)
    {
        if (_data != null)
        {
            string JSONData = JsonUtility.ToJson(_data, true);

            if (JSONData.Length != 0)
            {
                Debug.Log("JSON STRING: " + JSONData);
                string fileName = _fileName + ".json";
                string filePath = Path.Combine(Application.dataPath + "/Resources/JSONS/", fileName);
                File.WriteAllText(filePath, JSONData);
                Debug.Log("JSON almacendo en la dirección: " + filePath);
            }
            else
            {
                Debug.LogWarning("ERROR - FileSystem: JSONData is empty, check for local variable [string JSONData]");
            }
        }
        else
        {
            Debug.LogWarning("ERROR - FileSystem: _data is null, check for param  [object _data]");
        }
    }

}
