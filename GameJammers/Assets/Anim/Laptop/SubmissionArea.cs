using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmissionArea : MonoBehaviour
{
    public Laptop LapRef;
    Animator s_anim;
    // Start is called before the first frame update
    void Start()
    {
        s_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LapRef.Item1.GetComponent<LoadingBar>().ItemReady == true && LapRef.Item2.GetComponent<LoadingBar>().ItemReady == true && LapRef.Item3.GetComponent<LoadingBar>().ItemReady == true)
        {
            s_anim.GetComponent<Animator>().SetTrigger("Ready");
        }
    }
}
