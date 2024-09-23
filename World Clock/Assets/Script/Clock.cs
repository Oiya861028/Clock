using System;
using UnityEngine;
using TMPro;
public class Clock : MonoBehaviour
{

   
    public int timeZoneOffset = 0;
    public TextMeshPro Location, timeNow;
    public string text = "";
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    
    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    void Awake()
    {
        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, degreesPerHour * DateTime.Now.Hour);
        minutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, degreesPerMinute * DateTime.Now.Minute);
        secondsPivot.localRotation =
            Quaternion.Euler(0f, 0f, degreesPerSecond * DateTime.Now.Second);
        
    }

    void Update()
    {
        Location.text = text;
        UpdateClock();   
    }
    void UpdateClock()
    {
        // Get the current UTC time and apply the time zone offset
        DateTime time = DateTime.UtcNow.AddHours(timeZoneOffset);
        timeNow.text = time.ToString("hh:mm:ss tt");
        // Set the rotation of clock hands based on the adjusted time
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -time.Hour * degreesPerHour - (time.Minute * .5f));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -time.Minute * degreesPerMinute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -time.Second * degreesPerSecond);
    }

}