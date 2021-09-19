using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;

public class CallAPI : MonoBehaviour {
    private RequestHelper currentRequest;
    public string data;
    public Canvas canvas;
    public bool toggle = false;
    private GUIStyle guiStyle = new GUIStyle();
    
    private void LogMessage(string title, string message) {
#if UNITY_EDITOR
        EditorUtility.DisplayDialog (title, message, "Ok");
#else
		Debug.Log(message);
#endif
    }
    
    public void Post()
    {

        // We can add default query string params for all requests
        RestClient.DefaultRequestParams["param1"] = "My first param";
        RestClient.DefaultRequestParams["param3"] = "My other param";
        
        currentRequest = new RequestHelper {
            Uri = "http://101.132.76.183:8000/coupon",
            Params = new Dictionary<string, string> {
                { "param1", "value 1" },
                { "param2", "value 2" }
            },
            Body = new Post {
                title = "foo",
                body = "bar",
                userId = 1
            },
            EnableDebug = true
        };
        RestClient.Post<Post>(currentRequest)
            .Then(res =>
            {

                // And later we can clear the default query string params for all requests
                RestClient.ClearDefaultParams();

                //this.LogMessage("Avaliable Promotion Codes: ", JsonUtility.ToJson(res, true));
                data = res.ToString();
            })
            .Catch(err => this.LogMessage("Error", err.Message));
    }

    public void OnGUI()
    {
        if (toggle == false) {
            toggle = true;
            //GUI.enabled = true;
            //GUI.contentColor = Color.white;
            //guiStyle.fontSize = 20;
            //GUI.skin.button.wordWrap = true;
            GUI.Label(new Rect(800, 400, 300, 300), data);
        }
        else
        {
            toggle = false;
            // GUI.enabled = false;
            // GUI.contentColor = Color.black;
            // guiStyle.fontSize = 50;
            GUI.Label(new Rect(800, 600, 500, 400), "");

        }
    }
    
    public void popUp()
    {
        if (toggle == false) {
            toggle = true;
            canvas.enabled = true;
        }
        else
        {
            toggle = false;
            canvas.enabled = false;
    
        }
    }
        
}
