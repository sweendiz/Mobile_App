using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour {

    public UnityEngine.UI.Text woodText;
    public UnityEngine.UI.Text WPC;
    public float wood = 0.00f;
    public int woodclick = 1;

    void Update() {
        woodText.text = "Wood: " + wood;
        WPC.text = woodclick + " wood/click"; 
    }
    public void clicked() {
        wood += woodclick;
    }

}
