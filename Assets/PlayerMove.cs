﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;
using Yarn.Unity.Example;

public class PlayerMove : MonoBehaviour
{
	public float VelX, VelY, MaxX, MaxY;
	public GameObject nonPlayable, InventoryUI;
	public bool pause = false, stopped = false, inventory = false;
    //public Animator animator;
	public Text InventoryTxt;

    void Update()
    {
    	VelX = 0;
    	VelY = 0;

    	/*if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == true) {
            return;
        }*/
    	VelX = 0;
    	VelY = 0;
    	if (!pause)
    	{
	        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
	        	VelX +=5;
	        }
	        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
	        	VelX -=5;
	        }
	        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
	        	VelY +=5;
	        }
	        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
	        	VelY -=5;
	        }
	    }

        if (Input.GetKeyDown(KeyCode.P)) {
            pause = !pause;
            inventory = !inventory;
        }

        if (inventory) {
            InventoryUI. SetActive(true);
        } else {
            InventoryUI. SetActive(false);
        }

        //animator.SetFloat("VelX", VelX);
        //animator.SetFloat("VelY", VelY);

        stopped = (VelX == 0 && VelY == 0) ? true : false;
        //animator.SetBool("Stopped", stopped);

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (VelX, VelY);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
    	//nonPlayable.GetComponent<NPCMove>().Activate();
    	pause = true;
    	Destroy(col.gameObject);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
    	if (col.gameObject.GetComponent<NPC>() != null) {
    		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
            //animator.SetBool("Stopped", true);
    		//CheckForNearbyNPC (col.gameObject);
			if (col.gameObject.tag == "Object") {
				col.gameObject.SetActive(false);
			}
    	}

    	/*if (col.gameObject.GetComponent<SceneSwap>() != null) {
    		col.gameObject.GetComponent<SceneSwap>().SceneLoad();
    	}*/
    }

    /*public void CheckForNearbyNPC(GameObject collided)
    {
    	var allParticipants = new List<NPC> (FindObjectsOfType<NPC> ());    	
        var target = collided.GetComponent<NPC>();
        if (target != null) {
            // Kick off the dialogue at this node.
            FindObjectOfType<DialogueRunner> ().StartDialogue (target.talkToNode);
        }
    }*/
}
