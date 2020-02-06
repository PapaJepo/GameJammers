using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject timerref;
    public Slider scoreref;
    public TMP_Text time, Score;

    public List<GameObject> UIstuff;
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
        for (int i = 0; i<UIstuff.Count; i++)
        {
            UIstuff[i].SetActive(true);
        }
        Debug.Log(timerref.GetComponent<Timer>().timerc);
        time.text = "Your final time is:" + (timerref.GetComponent<Timer>().timerc.ToString("f0"));
        Score.text = "Your final rating is: " + (100 - scoreref.value).ToString("f0");

    }
}
