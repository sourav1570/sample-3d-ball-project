using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect3rdstar : MonoBehaviour {

    public GameObject stars3;

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            stars3.SetActive(false);
        }
    }
}
