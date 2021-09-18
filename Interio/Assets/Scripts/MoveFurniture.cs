using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveFurniture : MonoBehaviour
{
    // Start is called before the first frame update
    public Color green;
    public Color red;
    public Button button;

    public GameObject camera;

    [HideInInspector]
    public bool canMoveFurniture = true;

    void Start(){
        ColorBlock cb = button.colors;
        cb.normalColor = red;
        cb.highlightedColor = red;
        cb.pressedColor = red;
        cb.selectedColor = red;
        cb.disabledColor = red;
        button.colors = cb;
    }

    void Update(){}

    public void EnableFurnitureMovement(){
        ColorBlock cb = button.colors;
        if(canMoveFurniture){
            cb.normalColor = green;
            cb.highlightedColor = green;
            cb.pressedColor = green;
            cb.selectedColor = green;
            cb.disabledColor = green;
            button.colors = cb;
            canMoveFurniture = false;
            camera.GetComponent<CameraMove>().enabled = false;
        }else{
            cb.normalColor = red;
            cb.highlightedColor = red;
            cb.pressedColor = red;
            cb.selectedColor = red;
            cb.disabledColor = red;
            button.colors = cb;
            canMoveFurniture = true;
            camera.GetComponent<CameraMove>().enabled = true;
        }

    }

}
