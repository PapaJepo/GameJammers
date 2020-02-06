using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public GameObject timerref;
    public TMP_Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckTime()
    {
        Debug.Log(timerref.GetComponent<Timer>().timerc);
        Score.text = "" + (100 - timerref.GetComponent<Timer>().timerc);
    }
}
