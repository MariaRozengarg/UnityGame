using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class Escape2Script : MonoBehaviour
{
    public AudioSource srs;
    public AudioSource sourceMain;
    public GameObject countDown;
    public GameObject canvasPause;

    //bool isOutsideScreen = false;
    //bool isLocked;
    public float timing; // останавливает время
    public bool isPaused; // проверка паузы
    //public Transform pause;

    //public GameObject butStop;

    void Start()
    {

        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
        // isLocked = true;
    }

    public void Pause(bool pause)
    {
        if (isPaused == false)
        {
            canvasPause.SetActive(true);

            isPaused = true;
            //isOutsideScreen = true;

            AudioSource[] srs = GetComponents<AudioSource>(); // отключение звуков машины 
            for (int i = 0; i <= 3; i++)
            {
                srs[i].enabled = false;
            }
        }

        if (isPaused == true)
        {
            timing = 0;
        }
        else if (isPaused == false)
        {
            timing = 1;
        }
    }

    void Update()
    {
        Time.timeScale = timing;

#if MOBILE_INPUT // пауза на кнопку 

#else // пауза на клавишу
        //if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && isLocked)

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            canvasPause.SetActive(true);

            isPaused = true;
            //sOutsideScreen = true;

            // Cursor.lockState = CursorLockMode.None;
            // Cursor.visible = true;
            // isLocked = false;

            AudioSource[] srs = GetComponents<AudioSource>(); // отключение звуков машины 
            for (int i = 0; i <= 3; i++)
            {
                srs[i].enabled = false;
            }
        }

#endif

        //else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true && !isLocked)
        //{
        //    isPaused = false;
        //    isOutsideScreen = false;

        //    Cursor.lockState = CursorLockMode.Locked;
        //    Cursor.visible = false;
        //    isLocked = true;

        //    //SetCursorLock(false);
        //}

        if (isPaused == true)
        {
            timing = 0;
        }
        else if (isPaused == false)
        {
            timing = 1;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Race2");
    }

    public void Continue()
    {
        canvasPause.SetActive(false);

        isPaused = false;
        //isOutsideScreen = false;

        AudioSource[] srs = GetComponents<AudioSource>(); 
        for (int i = 0; i <= 3; i++)
        {
            srs[i].enabled = true;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuCopy");
        sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
        sourceMain.enabled = true;
    }
    // void OnGUI()
    // {
    //     if (isOutsideScreen)
    //     {
    //         GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Pause");

    //         if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 25), "Restart"))
    //         {
    //             SceneManager.LoadScene("Race2");
    //         }

    //         if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 25), "Continue"))
    //         {
    //             isPaused = false;
    //             isOutsideScreen = false;

    //             // Cursor.lockState = CursorLockMode.Locked;
    //             // Cursor.visible = false;
    //             // isLocked = true;

    //             AudioSource[] srs = GetComponents<AudioSource>(); 
    //             for (int i = 0; i <= 3; i++)
    //             {
    //                 srs[i].enabled = true;
    //             }
    //         }

    //         if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 25), "Main Menu"))
    //         {
    //             SceneManager.LoadScene("MainMenuCopy");
    //             sourceMain = GameObject.Find("Sound").GetComponent<AudioSource>();
    //             sourceMain.enabled = true;
    //         }
    //     }
    // }
}