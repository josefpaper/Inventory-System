using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> items = new List<Item>();

    public GameObject InventoryItem;
    public Transform InventoryContent;

    public float val = 0;

    void Awake()
    {
        Instance = this; 
    }
    public void Add(Item item)
    {
        items.Add(item);
        ListItems();
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }
    public void ListItems()
    {
        val = 0;
        foreach(Transform item in InventoryContent)
        {
            Destroy(item.gameObject);
        }
        foreach (Item item in items)
        {
            val += item.value;
            GameObject obj = Instantiate(InventoryItem, InventoryContent);
            var name = obj.transform.Find("Name").GetComponent<Text>();
            name.text = item.name;
        }
    }
}
