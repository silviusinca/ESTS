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
    private string objectString;
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventar").GetComponent<Inventory>();
       
    }

    public void Awake()
    {
        int index = gameObject.ToString().IndexOf("(");
        objectString = gameObject.ToString().Substring(0, index);
        if (!PlayerPrefs.HasKey(objectString))
        {
            PlayerPrefs.SetInt(objectString, 0);
            PlayerPrefs.Save();
        }
        Debug.Log(objectString);
        int isDestroyed = PlayerPrefs.GetInt(objectString);
        Debug.Log(isDestroyed);
        if (isDestroyed == 1)
        {
            Destroy(gameObject);
        }
    }
    public void OnMouseDown()
    {
        PlayerPrefs.SetInt(objectString, 1);
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
