using Dummiesman;
using System.IO;
using UnityEngine;

public class ObjFromFile : MonoBehaviour
{
    string objPath = string.Empty;
    string error = string.Empty;
    GameObject loadedObject;
    private GUIStyle guiStyle = new GUIStyle();

    void OnGUI() {
        objPath = GUI.TextField(new Rect(50, 50, 300, 50), objPath);

        guiStyle.fontSize = 30;
        GUI.Label(new Rect(50, 50, 400, 50), "Obj Path:", guiStyle);
        if(GUI.Button(new Rect(106, 109, 200, 20), "Load File"))
        {
            //file path
            if (!File.Exists(objPath))
            {
                error = "File doesn't exist.";
            }else{
                if(loadedObject != null)            
                    Destroy(loadedObject);
                loadedObject = new OBJLoader().Load(objPath);
                error = string.Empty;
            }
        }

        if(!string.IsNullOrWhiteSpace(error))
        {
            GUI.color = Color.red;
            GUI.Box(new Rect(800, 464, 256 + 64, 300), error);
            GUI.color = Color.white;
        }
    }
}
