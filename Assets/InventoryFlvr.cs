using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryFlvr : MonoBehaviour
{
    public Text InventoryTxt;
    public SpriteRenderer sprR;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update() {
    }

    public void slotOnClick() {
        Debug.Log("Clicked...");
        switch(sprR.sprite.name) {
                     case "wallet":
                     InventoryTxt.text = "This small piece of leather holds your entire life";
                     break;
                     case "pencilcase":
                     InventoryTxt.text = "The truth is... This actually holds pens!";
                     break;
                     case "earbuds":
                     InventoryTxt.text = "Used to shut out the world";
                     break;
                     case "proteinbar":
                     InventoryTxt.text = "Strawberry-flavored!";
                     break;
                     default:
                     InventoryTxt.text = sprR.sprite.name;
                     Debug.Log("Slot!");
                     break;
            }
    }
}
