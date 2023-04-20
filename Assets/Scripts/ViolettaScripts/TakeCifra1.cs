using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCifra1 : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(GameObject.Find("Cifra1"));
    }
}
