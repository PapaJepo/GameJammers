using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
    public Transform HoldPos;
    public Transform HoldPos1;
    bool PickedUp1,PickedUp2;
    MeshRenderer ColorSet;
    public GameObject PlayerRef;
  
    // Start is called before the first frame update
    void Start()
    {
        
        //ColorSet = GetComponent<MeshRenderer>();
    }
  
    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetMouseButton(0) && PickedUp1 == true)
            {
                PlayerRef.GetComponent<Movement>().picked = true;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                this.GetComponent<Rigidbody>().useGravity = false;
                this.GetComponent<Collider>().isTrigger = true;
                this.transform.parent = HoldPos.transform;
                this.transform.position = HoldPos.position;

            }
            else if (Input.GetMouseButton(1) && PickedUp2 == true)
            {
                PlayerRef.GetComponent<Movement>().picked = true;
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                this.GetComponent<Rigidbody>().useGravity = false;
                this.GetComponent<Collider>().isTrigger = true;
                this.transform.parent = HoldPos1.transform;
                this.transform.position = HoldPos1.position;
            }
            
            if(Input.GetMouseButtonUp(0))
            {
                PlayerRef.GetComponent<Movement>().picked = false;
                this.transform.parent = null;
                this.GetComponent<Rigidbody>().useGravity = true;
                this.GetComponent<Collider>().isTrigger = false;
                PickedUp1 = false;
                PickedUp2 = false;

            }
       }
     

 
    private void OnTriggerStay(Collider other)
    {
       
            if (other.gameObject.CompareTag("Player1") && PlayerRef.GetComponent<Movement>().picked == false)
            {
                PickedUp1 = true;
                //ColorSet.material.SetColor("", Color.red);
                // this.transform.position = HoldPos.position;
            }
            else if (other.gameObject.CompareTag("Player2")&& PlayerRef.GetComponent<Movement>().picked == false)
            {
                PickedUp2 = true;
                //ColorSet.material.SetColor("", Color.red);
                // this.transform.position = HoldPos.position;
            }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            PickedUp1 = false;
            PickedUp2 = false;

        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            PickedUp1 = false;
            PickedUp2 = false;

        }
    }
    /*
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            PickedUp1 = false;
            PickedUp2 = false;

        }
        else if (collision.gameObject.CompareTag("Player1"))
        {
            PickedUp1 = false;
            PickedUp2 = false;

        }
    }
    */

}
