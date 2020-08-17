using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectScript : MonoBehaviour
{
    public Sprite newSprite;
    public GameObject slot;
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
    	slot.GetComponent<SpriteRenderer>().sprite = newSprite;
        inventoryTxt.text = "This small piece of leather holds your entire life";
        gameObject.SetActive(false);
    }
}
