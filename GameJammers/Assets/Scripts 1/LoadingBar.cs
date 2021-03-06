﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LoadingBar : MonoBehaviour
{

    public Slider LoadBar;
    public GameObject Finish;
    public bool ItemReady = false;
    public ItemCheck ItemBool;

    public AudioSource SFX;
   private  new AudioSource audio;
    public GameObject Reset;
    // Start is called before the first frame update
    void Start()
    {
        //Finish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(LoadBar.value >= LoadBar.maxValue)
        {
            Finish.GetComponent<Animator>().SetTrigger("Tick");
            //Finish.SetActive( true);
            ItemReady = true;
            if (Reset.GetComponent<Laptop>().reset == true)
            {
                Finish.SetActive(false);
                ItemReady = false;
                LoadBar.value = LoadBar.minValue;
            }
        }
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            if (LoadBar.value < LoadBar.maxValue && Input.GetKey(KeyCode.G) && ItemBool.iteminarea == true)
            {
                StartCoroutine("Load");
                
            }
            if (Input.GetKey(KeyCode.G) && ItemBool.iteminarea == true)
            {
                if(!SFX.isPlaying)
                {
                    SFX.Play();
                }
            }
            //LoadBar.value += 0.1f;
            //ColorSet.material.SetColor("", Color.red);
            // this.transform.position = HoldPos.position;
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            if (LoadBar.value < LoadBar.maxValue && Input.GetMouseButton(1) && ItemBool.iteminarea == true)
            {
                //StartCoroutine("AudioPlay");
                StartCoroutine("Load");
              
            }
            if (Input.GetMouseButton(1) && ItemBool.iteminarea == true)
            {
                if (!SFX.isPlaying)
                {
                    SFX.Play();
                }
            }
            /*else
            {
                SFX.Pause();
            }*/
            //LoadBar.value += 0.1f;
            //ColorSet.material.SetColor("", Color.red);
            // this.transform.position = HoldPos.position;
        }
        /*
        else if (other.gameObject.CompareTag("Player2"))
        {
            PickedUp2 = true;
            Debug.Log("Item in Range");
            //ColorSet.material.SetColor("", Color.red);
            // this.transform.position = HoldPos.position;
        }
        */
    }

    IEnumerator Load()
    {
        LoadBar.value += 0.3f;
       
        yield return new WaitForSeconds(0.1f);
    }

   /* IEnumerator AudioPlay()
    {
        SFX.Play();
        yield return new WaitForSeconds(5f);
    }*/
}
