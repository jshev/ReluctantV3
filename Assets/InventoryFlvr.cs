using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InventoryFlvr : MonoBehaviour
{
    public Text InventoryTxt;
    public SpriteRenderer sprR;
     public GameObject definedButton;
     public UnityEvent OnClick = new UnityEvent();
 
     // Use this for initialization
     void Start () {
         //sprR = gameObject.GetComponent<SpriteRenderer>();
         Debug.Log("Hello World!");
         definedButton = this.gameObject;
     }
     
     // Update is called once per frame
     void Update () {
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit Hit;
         
         if (Input.GetMouseButtonDown(0))
         {
             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
             {
                 Debug.Log("Button Clicked");
                 OnClick.Invoke();
             }
         }    
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
