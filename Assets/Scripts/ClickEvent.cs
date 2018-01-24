using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour {

    public UnityEngine.UI.Text woodText;
    public int wood = 0;
    public int woodclick = 1;

    void Update() {
        woodText.text = "Wood: " + wood;
    }
    public void clicked() {
        wood += woodclick;
    }

}
