﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialougeUIScript : MonoBehaviour
{
    public GameObject dialoguebox;
    public Text dialoguetext;
    public Text dialougeName;
    // Start is called before the first frame update
    void Start()
    {
         gameObject.tag = "Player";
         dialoguebox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag == "NPC"){
           dialoguebox.SetActive(true);
           Debug.Log("Triggered by NPC");
           DialougeSerializerScript script = new DialougeSerializerScript();
           dialougeName.text = script.LoadDialogue("text.xml").Name;
           dialoguetext.text = script.LoadDialogue("text.xml").Dialouge;

       }

    }

}
