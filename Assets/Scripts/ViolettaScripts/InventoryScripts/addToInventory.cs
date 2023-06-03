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
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventar").GetComponent<Inventory>();
       
    }

    public void Awake()
    {
        int isNotDestroyed = PlayerPrefs.GetInt(gameObject.ToString(), 1);
        if (isNotDestroyed == 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnMouseDown()
    {
        PlayerPrefs.SetInt(gameObject.ToString(), 0);
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
