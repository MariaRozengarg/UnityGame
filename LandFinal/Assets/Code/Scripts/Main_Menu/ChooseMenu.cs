using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseMenu : MonoBehaviour {

    // public GUIStyle myStyle;
    public AudioSource sourceMain;
    // Use this for initialization
    void Start () {
        // myStyle = new GUIStyle();
        // myStyle.fontSize = 30; // размер шрифта (очевидно) 
        // myStyle.normal.textColor = Color.black; // цвет шрифта (менее очевидно) 
		
	}

    public void StartRace1()
    {
        sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
        sourceMain.enabled = false;

        SceneManager.LoadScene("Race1");
    }

    public void StartRace2()
    {
        sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
        sourceMain.enabled = false;

        SceneManager.LoadScene("Race2");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenuCopy");
    }

    // void OnGUI()
    // {
    //     //GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 200), "Choose level");
    //     GUI.Box(new Rect(Screen.width / 2 - Screen.height / 2 / 2, Screen.height / 2 + Screen.width / 25, Screen.height / 2, Screen.width / 25 * 5), "Выберите уровень");

    //     //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 25), "Himalayas"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 2, Screen.height / 3, Screen.width / 25), "Гималаи"))
    //     {
    //         sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
    //         sourceMain.enabled = false;

    //         SceneManager.LoadScene("Race1");
    //     }

    //     //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 250, 100, 25), "Sonnenwind"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 3, Screen.height / 3, Screen.width / 25), "Сонненвинд"))
    //     {
    //         sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
    //         sourceMain.enabled = false;

    //         SceneManager.LoadScene("Race2");
    //     }

    //     //if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 300, 100, 25), "Main Menu"))
    //     if (GUI.Button(new Rect(Screen.width / 2 - (Screen.height / 3) / 2, Screen.height / 2 + Screen.width / 25 * 4, Screen.height / 3, Screen.width / 25), "Главное меню"))
    //     {
    //         SceneManager.LoadScene("MainMenu");
    //     }

    //     GUI.Label(new Rect(25, Screen.height - myStyle.fontSize * 2, 100, 70), "Выполнила: Розонова Мария, ДЦисБ-4-3.", myStyle);
    // }
}
