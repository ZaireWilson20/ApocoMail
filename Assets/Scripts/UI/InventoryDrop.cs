using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDrop : MonoBehaviour
{
    [SerializeField] private Animator _inventoryDrop;
    void OnMouseOver(){
        _inventoryDrop.SetBool("hovering", true);
        print("hewwo");
    }
    void OnMouseExit(){
        _inventoryDrop.SetBool("hovering", false);
    }
}
