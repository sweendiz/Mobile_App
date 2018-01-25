using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodPerSec : MonoBehaviour {


    public ClickEvent click;
    public UnityEngine.UI.Text wpsDisplay;
    public ItemController[] items;


    void Start() {
        StartCoroutine(AutoTick());
    }
    void Update() {
        wpsDisplay.text = GetWoodPerSec() + "wood/sec";

    }

    public int GetWoodPerSec() {
        int tick = 0;
        foreach (ItemController item in items) {
            tick += item.count * item.tickValue;
        }
        return tick;


    }
    public void AutoWoodPerSec() {
        click.wood += GetWoodPerSec();

    }
    IEnumerator AutoTick() {
        while (true) {
            AutoWoodPerSec();
            yield return new WaitForSeconds(1);

        }


    }
    
}
