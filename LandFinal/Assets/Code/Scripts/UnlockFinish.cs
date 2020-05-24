using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockFinish : MonoBehaviour {

    public GameObject finish;
    public GameObject unFinish;
    public GameObject unFinish1;
    public GameObject unFinish2;
    public GameObject unFinish3;
    public GameObject unFinish4;

    public static string result;
    public Text textOutput;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Unlock")
        {
            finish.SetActive(true);
            unFinish.SetActive(false);
        }

        if (other.transform.tag == "Unlock1")
        {
            unFinish.SetActive(true);
            textOutput.text = "3/3";
            unFinish1.SetActive(false);
        }

        if (other.transform.tag == "Unlock2")
        {
            unFinish1.SetActive(true);
            unFinish2.SetActive(false);
        }

        if (other.transform.tag == "Unlock3")
        {
            unFinish2.SetActive(true);
            textOutput.text = "2/3";
            unFinish3.SetActive(false);
        }

        if (other.transform.tag == "Unlock4")
        {
            unFinish3.SetActive(true);
            unFinish4.SetActive(false);
        }
    }

}
