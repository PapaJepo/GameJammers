using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    GameObject pickedUp;
    float holdDistance;
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.red);
        if(Input.GetMouseButton(0))
        {
            RaycastHit raycastHit;
            
            if(Physics.Raycast(transform.position,transform.forward,out raycastHit))
            {
                if(raycastHit.collider.gameObject.tag == "Carry")
                {
                    Debug.Log("RAYCASTHIT");
                    pickedUp = raycastHit.collider.gameObject;
                    holdDistance = Vector3.Distance(pickedUp.transform.position, transform.position);
                }
                else
                {
                    pickedUp = null;
                }
            }
            else
            {
                Vector3 holdPos = transform.position + (transform.forward * holdDistance);
                Vector3 toHoldPos = holdPos - pickedUp.transform.position;
                pickedUp.GetComponent<Rigidbody>().velocity = toHoldPos;
            }

        }


    }
}
