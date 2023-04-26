using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Luminite : MonoBehaviour
{
    [SerializeField] GameObject visualEffects;
    Vector2 mouse;
    void Start(){
        visualEffects.SetActive(false);
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            visualEffects.SetActive(true);
            visualEffects.transform.position = new Vector3(mouse.x, mouse.y, 0f);
        }
        if (Input.GetMouseButtonUp(0)){
            visualEffects.SetActive(false);
        }
    }
}

 