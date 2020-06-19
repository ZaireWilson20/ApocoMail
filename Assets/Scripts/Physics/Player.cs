﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float move_speed;
    [SerializeField]
    private float diag_speed;
    private Vector3 input;
    public Yarn.Unity.Example.NPC collided_npc = null;



    [SerializeField]
    private GameObject giveQuestUI; 
    private bool inside_npc_radius = false;
    public string current_npc_startNode = "";


    public GameObject interaction_bubble;


    private CharacterController char_cont;
    // Start is called before the first frame update
    void Start()
    {
        char_cont = this.GetComponent<CharacterController>();
        giveQuestUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        if (inside_npc_radius && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("yo");
            StartNpcDialogue(current_npc_startNode);
        }

        if (Input.GetKeyDown(KeyCode.G) && collided_npc != null)
        {
            Inventory.GetInstance().AddToInventory(collided_npc.GetItemToGive());
            InvenUI.GetInstance().ShowItem(collided_npc.inventoryIndex);

        }

    }

    private void FixedUpdate()
    {
        if (input.x != 0 && input.y != 0)
        {
            char_cont.Move(input * move_speed * (diag_speed / 100));
        }
        else
        {
            char_cont.Move(input * move_speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliding with npc");

        if (collision.tag == "NPC" || collision.tag == "PickUp")
        {
            //Debug.Log("Colliding with npc");
            inside_npc_radius = true;
            //interaction_bubble.SetActive(true);


            collided_npc = collision.gameObject.GetComponent<Yarn.Unity.Example.NPC>();
            Debug.Log(collided_npc);
            current_npc_startNode = collided_npc.talkToNode;
            //collided_npc.GivePlayerItem();

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "NPC" || collision.tag == "PickUp")
        {
           // interaction_bubble.SetActive(false);
            inside_npc_radius = false;
            current_npc_startNode = "";
            collided_npc = null; 
        }
    }

    public void StartNpcDialogue(string startNode)
    {
        if (startNode != null)
        {
            // Kick off the dialogue at this node.
            FindObjectOfType<DialogueRunner>().StartDialogue(startNode);
        }
    }

    [YarnCommand ("CheckInventory")]
    public void ShowGiveQuestUI(string item)
    {
        if (Inventory.GetInstance().InInventory(item))
        {
            giveQuestUI.SetActive(true);
        }
        
    }

    public void SetCollidedNPCActive(bool state)
    {
        collided_npc.SetProfileActive(state);
    }
}
