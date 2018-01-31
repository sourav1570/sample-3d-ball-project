using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcollector : MonoBehaviour
{
    public GameObject stars1;

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            stars1.SetActive(false);
        }
    }
}
