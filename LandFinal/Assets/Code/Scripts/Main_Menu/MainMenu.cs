using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // private GUIStyle myStyle;
    // private GUIStyle textStyle;
    
    // Use this for initialization
    void Start()
    {
        // myStyle = new GUIStyle();
        // myStyle.fontSize = 30; // размер шрифта (очевидно) 
        // myStyle.normal.textColor = Color.black; // цвет шрифта (менее очевидно) 

        // textStyle = new GUIStyle();
        // textStyle.fontSize = 40; // размер шрифта (очевидно) 
        // textStyle.alignment = TextAnchor.UpperCenter;
        //textStyle.border = RectOffset.top;
        //textStyle.normal.textColor = Color.black; // цвет шрифта (менее очевидно) 

    }

    public void ChooseMenu()
    {
        SceneManager.LoadScene("ChooseMenuCopy");
    }

    public void NetworkMenu()
    {
        SceneManager.LoadScene("NetworkMenuCopy");
    }

    public void Exit()
    {
       Application.Quit();
    }


    // void OnGUI()
    // {
    //     //GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 150), "Main Menu");
    //     GUI.Box(new Rect(Screen.width / 2 - Screen.height / 2 / 2, Screen.height / 2 + Screen.width / 25, Screen.height / 2, Screen.width / 25 * 5), "");

    //     //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 25), "Play"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 2, Screen.height / 3, Screen.width / 25), "Одиночная гонка"))
    //     {
    //         SceneManager.LoadScene("ChooseMenu");
    //     }

    //             //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 25), "Play"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 3, Screen.height / 3, Screen.width / 25), "Играть по сети"))
    //     {
    //         //SceneManager.LoadScene("ChooseMenu");
    //     }

    //     //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 250, 100, 25), "Quit"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 4, Screen.height / 3, Screen.width / 25), "Выход"))
    //     {
    //         Application.Quit();
    //     }


    //     GUI.Label(new Rect(25, Screen.height - myStyle.fontSize * 2, 100, 70), "Выполнила: Розонова Мария, ДЦисБ-4-3.", myStyle);
    // }
}