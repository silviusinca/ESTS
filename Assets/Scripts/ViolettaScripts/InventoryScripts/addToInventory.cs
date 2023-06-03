using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addToInventory : MonoBehaviour
{
    public Inventory inventory;
    public GameObject objectToAdd;
    private int isDestroyed;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey(gameObject.name))
        {
            PlayerPrefs.SetInt(gameObject.name, 0);
            PlayerPrefs.Save();
        }

        isDestroyed = PlayerPrefs.GetInt(gameObject.name);
        if (isDestroyed == 1)
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventar").GetComponent<Inventory>();
    }

    public void OnMouseDown()
    {
        if (isDestroyed != 1)
        {
            PlayerPrefs.SetInt(gameObject.name, 1);
            PlayerPrefs.Save();

            for (int i = 0; i < inventory.inventorySlots.Count; i++)
            {
                if (!inventory.isFull[i])
                {
                    if (gameObject != null)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(objectToAdd, inventory.inventorySlots[i].transform, false);
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }
    }
}
