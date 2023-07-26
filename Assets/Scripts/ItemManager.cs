using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private void OnEnable()
    {
        Item.OnItemCollected += ItemCollected;
    }

    private void ItemCollected()
    {
        Debug.Log("Item is collected");
    }

    private void OnDisable()
    {
        Item.OnItemCollected -= ItemCollected;
    }
}
