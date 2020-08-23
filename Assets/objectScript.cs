using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectScript : MonoBehaviour
{
    public Sprite newSprite;
    public string newTxt;
    //public GameObject slot;
    public GameObject[] Slots;
    public Text inventoryTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        foreach(GameObject slot in Slots) {
            if (slot.GetComponent<SpriteRenderer>().sprite.name == "empty") {
                slot.GetComponent<SpriteRenderer>().sprite = newSprite;
                inventoryTxt.text = newTxt;
                gameObject.SetActive(false);
                break;
            } else {
                continue;
            }
        }
    	//slot.GetComponent<SpriteRenderer>().sprite = newSprite;
        //inventoryTxt.text = "This small piece of leather holds your entire life";
        //gameObject.SetActive(false);
    }

    /*void CheckSlots(Sprite newSp, string newTxt){
        foreach(GameObject slot in Slots) {
            if (slot.GetComponent<SpriteRenderer>().sprite.name = "empty") {
                slot.GetComponent<SpriteRenderer>().sprite = newSp;
                inventoryTxt.text = newTxt;
                gameObject.SetActive(false);
                break;
            } else {
                continue;
            }
        }
    } */
}
