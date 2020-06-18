using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveQuestHandler : MonoBehaviour
{

    [SerializeField]
    private Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveToNPC()
    {
        if (player.collided_npc != null)
        {
            player.StartNpcDialogue(player.collided_npc.itemRecivedNode);
            InvenUI.GetInstance().RemoveItem(player.collided_npc.inventoryIndex);
        }
    }
}
