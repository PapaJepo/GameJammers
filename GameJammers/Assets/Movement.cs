using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 i_movement;
    float moveSpeed = 4f;

    public string Horizontal = "Horizontal_P1";
    public string Vertical = "Vertical_P1";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        float x = Input.GetAxisRaw(Horizontal);
        float z = Input.GetAxisRaw(Vertical);
        Debug.Log(x);

        Vector3 m = new Vector3(x, 0, z) * moveSpeed * Time.deltaTime;
       // transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(m),0.05f);
        transform.Translate(m, Space.World);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(m), 0.05f);

        while(x == 0 && z == 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(m), 0.05f);
        }

        
    }


 
}
