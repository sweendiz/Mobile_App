using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour {


    public UnityEngine.UI.Text cuttingPower;
    public UnityEngine.UI.Text woodText;
    public float wood = 0.00f;
    public int woodclick = 1;

    void Update() {
        woodText.text = "Wood: " + wood;
        cuttingPower.text = "Cutting power:" + woodclick;
    }
    public void clicked() {
        wood += woodclick;
    }

}
