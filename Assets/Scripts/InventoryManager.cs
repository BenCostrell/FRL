using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private InventorySlot[] inventorySlots;
    
    void Awake()
    {
        inventorySlots = GetComponentsInChildren<InventorySlot>();
    }

    private void Start()
    {
        
    }
}
