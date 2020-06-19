using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity; 

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private string item_name;
    [SerializeField]
    public string yarn_var;

    public KeyCode Test_Key_Code; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Test_Key_Code))
        {
            AddItemToInvenory(yarn_var); 
        }
    }

    [YarnCommand("AddItemToInventory")]
    public void AddItemToInvenory(string varName)
    {
        Debug.Log("come on");
        yarn_var = "$" + varName; 
        Inventory.GetInstance().AddToInventory(this.gameObject);


    }
}
