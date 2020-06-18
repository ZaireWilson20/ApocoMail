using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenUI : MonoBehaviour
{
    private static InvenUI instance = null; 
    public GameObject[] items;



    public static InvenUI GetInstance()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowItem(int index)
    {
        items[index].SetActive(true);
    }

    public void RemoveItem(int index)
    {
        items[index].SetActive(false);
    }
}
