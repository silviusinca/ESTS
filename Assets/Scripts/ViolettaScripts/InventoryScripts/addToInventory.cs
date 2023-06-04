using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addToInventory : MonoBehaviour
{
    public Inventory inventory;
    public GameObject objectToAdd;
    public bool isDestroyed = false;
    public static List<String> objectsAdded = new List<String>(); // aici retin toate obiectele adaugate
    public static Dictionary<string, bool> objectStatuses = new Dictionary<string, bool>(); //asta ma asigura ca se reseteaza playerPrefs
    private void Awake()
    {
        if (!objectStatuses.ContainsKey(gameObject.name))
        {
            objectStatuses[gameObject.name] = false;
        }
        if (!objectStatuses[gameObject.name])
        {
            PlayerPrefs.SetInt(gameObject.name, 0);
            objectStatuses[gameObject.name] = true;
            PlayerPrefs.Save();
        }
        isDestroyed = PlayerPrefs.GetInt(gameObject.name) == 1;
        if (isDestroyed)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventar").GetComponent<Inventory>();
    }
    private void OnMouseDown()
    {
        if (!isDestroyed)
        {
            PlayerPrefs.SetInt(gameObject.name, 1);
            PlayerPrefs.Save();

            for (int i = 0; i < inventory.inventorySlots.Count; i++)
            {
                if (!inventory.isFull[i])
                {
                    if (gameObject != null)
                    {
                        objectsAdded.Add(gameObject.name);
                        foreach (String g in objectsAdded)
                        {
                            Debug.Log(g);
                        }
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
