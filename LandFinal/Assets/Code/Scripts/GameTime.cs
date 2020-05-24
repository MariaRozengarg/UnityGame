using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTime : MonoBehaviour
{
    public static bool stop;
    public static string result;
    public bool reverse;
    public enum CounterMode { hourMinSec = 0, minSec = 1 };
    public CounterMode counterMode = CounterMode.hourMinSec;
    public int startMin, startSec, startMsec;
    public Text textOutput;
    public bool startAwake = true;
    private int min, sec, msec;
    private string m, s, ms;

    void Awake()
    {
        if (startAwake) stop = false; else stop = true;
        if (startMin > 0 && startMin <= 59) min = startMin; else startMin = 0;
        if (startSec > 0 && startSec <= 59) sec = startSec; else startSec = 0;
        if (startMsec > 0 && startMsec <= 9) msec = startMsec; else startMsec = 0;
    }

    void Start()
    {
        StartCoroutine(RepeatingFunction());
    }

    IEnumerator RepeatingFunction()
    {
        while (true)
        {
            if (!stop) TimeCount();
            yield return new WaitForSeconds(0.0829f);
        }
    }

    void TimeCount()
    {
        if (reverse)
        {
            if (msec < 0)
            {
                msec = 9;
                sec--;
            }
            if (sec < 0)
            {
                sec = 59;
                min--;
            }
            if (min < 0)
            {
                min = 59;
            }

            CurrentTime();
            msec--;
        }
        else
        {
            if (msec > 9)
            {
                msec = 0;
                sec++;
            }
            if (sec > 59)
            {
                sec = 0;
                min++;
            }
            if (min > 59)
            {
                min = 0;
            }

            CurrentTime();
            msec++;
        }
    }

    void CurrentTime()
    {
        if (msec < 0) ms = "0" + msec; else ms = msec.ToString();
        if (sec < 10) s = "0" + sec; else s = sec.ToString();
        if (min < 10) m = "0" + min; else m = min.ToString();
    }

    void OnGUI()
    {
        switch (counterMode)
        {
            case CounterMode.hourMinSec:
                result = m + ":" + s + ":" + ms;
                break;

            case CounterMode.minSec:
                result = m + ":" + s;
                break;
        }

        textOutput.text = result;
    }
}