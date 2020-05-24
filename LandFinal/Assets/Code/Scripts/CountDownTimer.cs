using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDownTimer : MonoBehaviour
{
    //public GameObject countDown;
    public GameObject enTimeText;
    GameObject imageFieldPrefab;
    public float time = 4;
    public float stepTime = 1;
    List<string> lines;

    void Start()
    {
        StartTimerInit(new List<string>() { "GO", "1", "2", "3", "" });
    }

    public void StartTimerInit(List<string> list)
    {
        time = list.Count - 1; //общее время формируется из количества элементов отсчета
        lines = list;
        imageFieldPrefab = Resources.Load("NumberImage") as GameObject;
        StartCoroutine(StartCountDown());
    }

    IEnumerator StartCountDown()
    {
        GameObject imageTimerObject = null;
        while (time > 0)
        {
            stepTime -= Time.deltaTime;//шаг одной пролетающей таблички

            if (stepTime > 0f)
            {
                if (imageTimerObject == null)
                {
                    imageTimerObject = Instantiate(imageFieldPrefab, this.transform) as GameObject;
                    imageTimerObject.transform.localScale = Vector3.one;
                }
                //последняя табличка зависает вместо изменения масштаба
                if ((int)time != 0)
                {
                    imageTimerObject.transform.Rotate(new Vector3(10, 0, 0));
                    imageTimerObject.transform.localScale = new Vector3(stepTime, stepTime, stepTime);
                }
            }
            else
            {
                stepTime = 1;
                Destroy(imageTimerObject.gameObject);
            }

            //общий таймер выхода корутина
            time -= Time.deltaTime;
            imageTimerObject.GetComponentInChildren<Text>().text = lines[(int)time];

            if ((int)time == 0)
            {
                enTimeText.SetActive(true);
                GameObject car = GameObject.Find("CarMain");
                CarUserControl control = car.GetComponent<CarUserControl>();
                control.enabled = true;
            }

            //if (time > 0) go.GetComponentInChildren<Text>().text = lines[((int)(lines.Count - time))]; обратный ход
            yield return null;
        }

        Destroy(imageTimerObject);
        //Destroy(this);
    }
}