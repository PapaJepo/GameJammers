using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck : MonoBehaviour
{
    public bool iteminarea;
    public string ItemTag = "CodeItem1";
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
        if(other.CompareTag(ItemTag))
        {
            iteminarea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(ItemTag))
        {
            iteminarea = false;
        }
    }
}
