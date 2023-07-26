using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Custom delegate declaration
    public delegate void ItemCollected();
    public static event ItemCollected OnItemCollected;

    void OnEnable()
    {
        OnItemCollected += PickupItem; 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnItemCollected?.Invoke();
        }
    }

    void PickupItem()
    {
        Debug.Log("Player picked up the item");
    }
}