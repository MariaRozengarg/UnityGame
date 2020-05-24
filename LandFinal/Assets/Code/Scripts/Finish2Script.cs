using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Finish2Script : MonoBehaviour
{
    public GameObject text;
    public GameObject canvasFinish;

    // bool isFinished = false;
    float check;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Finish")
        {
            canvasFinish.SetActive(true);

            // isFinished = true;

            GameObject car = GameObject.Find("CarMain");
            CarUserControl control = car.GetComponent<CarUserControl>();
            control.enabled = false;

            GameTime showText = text.GetComponent<GameTime>();
            showText.enabled = false;
        }
    }

    // void OnGUI()
    // {
    //     if (isFinished)
    //     {
    //         GUI.Box(new Rect(Screen.width / 2 - 230, Screen.height / 2 - 205, 460, 80), "Congratulations!");
    //         GUI.Label(new Rect(Screen.width / 2 - 210, Screen.height / 2 - 185, 420, 70), "You has completed the race in the middle of the village of Sonnenwind.\nI have finished this track in 00:15:3. Try to beat my record.\nPress \"Escape\" to restart or to go to the main menu.");
    //     }
    // }
}

