using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop : MonoBehaviour
{
    public Slider BugBar;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public bool reset = false;
    public GameObject Upload;

    public GameObject RdyAnim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Item1.GetComponent<LoadingBar>().ItemReady == true )
        {
            StartCoroutine("Load");
        }
        if (Item2.GetComponent<LoadingBar>().ItemReady == true)
        {
            StartCoroutine("Load");
        }
        if (Item3.GetComponent<LoadingBar>().ItemReady == true)
        {
            StartCoroutine("Load");
        }

        if(Item1.GetComponent<LoadingBar>().ItemReady == true&& Item2.GetComponent<LoadingBar>().ItemReady == true&& Item3.GetComponent<LoadingBar>().ItemReady == true)
        {
            RdyAnim.GetComponent<Animator>().SetTrigger("Ready");
        }


    }

    IEnumerator Load()
    {
        BugBar.value += 0.005f;
        yield return new WaitForSeconds(0.12f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SubmissionArea"))
        {
            if(Item1.GetComponent<LoadingBar>().ItemReady == true && Item2.GetComponent<LoadingBar>().ItemReady == true && Item3.GetComponent<LoadingBar>().ItemReady == true)
            {
                reset = true;
                Upload.SetActive(true);
                Item1.GetComponent<LoadingBar>().ItemReady = false;
                Item2.GetComponent<LoadingBar>().ItemReady = false;
                Item3.GetComponent<LoadingBar>().ItemReady = false;
                float tempval = BugBar.value;
                BugBar.value = BugBar.minValue;
                Debug.Log(tempval);
            }
        }
    }
}
