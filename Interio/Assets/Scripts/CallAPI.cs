using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;

public class CallAPI : MonoBehaviour {
    private RequestHelper currentRequest;
    
    private void LogMessage(string title, string message) {
#if UNITY_EDITOR
        EditorUtility.DisplayDialog (title, message, "Ok");
#else
		Debug.Log(message);
#endif
    }
    
    public void Post(){

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
            .Then(res => {

                // And later we can clear the default query string params for all requests
                RestClient.ClearDefaultParams();

                this.LogMessage("Avaliable Promotion Codes: ", JsonUtility.ToJson(res, true));
            })
            .Catch(err => this.LogMessage("Error", err.Message));
    }
        
}
