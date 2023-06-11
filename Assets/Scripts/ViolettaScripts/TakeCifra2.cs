using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCifra2 : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(GameObject.Find("Cifra2"));
    }
}
