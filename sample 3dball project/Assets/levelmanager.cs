using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {

  public void level1()
    {
        Application.LoadLevel("gameplay");
    }
    public void level2()
    {
        Application.LoadLevel("level2");
    }
}
