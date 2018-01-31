using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect2ndstar : MonoBehaviour {

    public GameObject stars2;

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Player")
        {
            stars2.SetActive(false);
        }
    }
}
