using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public TMP_Text time;

    public GameObject GameOver;

    public GameObject EndAnim;

    public float timerc = 300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(timerc > 0f)
        {
            time.text = "" + timerc.ToString("f0");

            timerc -= Time.deltaTime;
        }
        else if(timerc <= 0f)
        {
            timerc = 0f;
            EndAnim.GetComponent<Animator>().SetTrigger("End");
        }
    }
}
