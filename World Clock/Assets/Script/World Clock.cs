using UnityEngine;
public class WorldClockManager : MonoBehaviour
{
    // Reference to your clock prefab
    public GameObject clockPrefab1;
    public GameObject clockPrefab2;
    public GameObject clockPrefab3;
    public GameObject clockPrefab4;


    void Start()
    {
        // Instantiate the New York clock
        GameObject newYorkClock = Instantiate(clockPrefab1, new Vector3(-5, 0, 0), Quaternion.identity);
        Clock newYorkClockScript = newYorkClock.GetComponent<Clock>( );
        newYorkClock.name = "New York Clock";
        if (newYorkClockScript != null)
        {
            newYorkClockScript.timeZoneOffset = -4; // New York is UTC-4 (adjust for DST if necessary)
            newYorkClockScript.text = "New York";
        }


        // Instantiate the San Francisco clock
        GameObject sanFranciscoClock = Instantiate(clockPrefab2, new Vector3(5, 0, 0), Quaternion.identity);
        Clock sanFranciscoClockScript = sanFranciscoClock.GetComponent<Clock>( );
        sanFranciscoClock.name = "San Francisco Clock";
        if (sanFranciscoClockScript != null)
        {
            sanFranciscoClockScript.timeZoneOffset = -7; // San Francisco is UTC-7 (adjust for DST if necessary)
            sanFranciscoClockScript.text = "San Francisco";
        }
        
        // Instantiate the Beijing Clock
        GameObject beijingClock = Instantiate(clockPrefab3, new Vector3(-5, 12, 0), Quaternion.identity);
        Clock beijingClockScript = beijingClock.GetComponent<Clock>( );
        beijingClock.name = "Bei Jing Clock";
        if (beijingClockScript != null)
        {
            beijingClockScript.timeZoneOffset = 8; // Bei Jing is UTC+8 (adjust for DST if necessary)
            beijingClockScript.text = "Beijing";
        }

        // Instantiate the London Clock
        GameObject LondonClock = Instantiate(clockPrefab4, new Vector3(5, 12, 0), Quaternion.identity);
        Clock LondonClockScript = LondonClock.GetComponent<Clock>( );
        LondonClock.name = "London Clock";
        if (LondonClockScript != null)
        {
            LondonClockScript.timeZoneOffset = 1; // London is UTC+1 (adjust for DST if necessary)
            LondonClockScript.text = "London";
        }

    }
}
