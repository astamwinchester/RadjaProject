using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController instance;

    public List<string> itemList;

    public void AddItem (string itemName)
    {
        itemList.Add(itemName);
    }

    public void RemoveItem(string itemName)
    {
        if (ContainItem(itemName))
            itemList.Remove(itemName);
    }

    public bool ContainItem (string itemName)
    {
        return itemList.Contains(itemName);
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {

    }
}