using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item" , menuName ="Item/Create New Item")] 
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Consumable,
        Nonconsumable
    }
    public string ItemName;
    public ItemType type;
    public int value;
    

}
