using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public static bool IsInputEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        this.gameObject.SetActive(false);
        IsInputEnabled = true;
    }
}
