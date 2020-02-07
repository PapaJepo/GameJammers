using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    public GameObject PosterUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player1")  && Input.GetKey(KeyCode.G))
        {
            PosterUI.SetActive(true);
        }

        if (other.gameObject.CompareTag("Player2") && Input.GetMouseButton(1)) 
        {
            PosterUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            PosterUI.SetActive(false);
        }

    }
}
