using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Inventory : MonoBehaviour
{

    public static Inventory instance = null; 
    private Dictionary<string, UI_Inventory> inventory_dict;
    public InMemoryVariableStorage yarn_variables; 
    
    [SerializeField]
    private GameObject inv_ui; 


    public static Inventory GetInstance()
    {
        return instance; 
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this; 
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inventory_dict = new Dictionary<string, UI_Inventory>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool InInventory(string itemName)
    {
        foreach(KeyValuePair<string, UI_Inventory> k in inventory_dict)
        {
            if(k.Value.name == itemName)
            {
                return true; 
            }
        }
        return false; 
    }
    public void AddToInventory(GameObject item)
    {
        UI_Inventory ui_inv = new UI_Inventory();
        ui_inv.name = item.name;
        ui_inv.inv_icon = item.GetComponent<Image>();
        inventory_dict.Add(ui_inv.name, ui_inv);

        yarn_variables.SetValue(item.GetComponent<PickUp>().yarn_var, true);


        //GameObject g = new GameObject();


        //g.AddComponent(typeof(Image));
        //g.name = ui_inv.name; 
        //g.GetComponent<Image>().sprite = ui_inv.inv_icon.sprite;
        

        //GameObject b =  Instantiate(g);
        //b.transform.parent = inv_ui.transform; 
        //b.GetComponent<Image>().color = ui_inv.inv_icon.color;
       // b.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 0);

    }

}

public class UI_Inventory
{
    public string name;
    public Image inv_icon; 
}
