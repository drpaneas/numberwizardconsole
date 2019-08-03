using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Instance variables (can be used at any method within the class)
    int max;
    int min;
    int guess;

    // Start method is called before the first frame update
    // All these things will run once (e.g. for first Setup)
    void Start()
    {
        StartGame();
    }

    // StartGame method prints debug messages in the console
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Think of a number (but not tell me about it) within the range:");
        Debug.Log("Maximum: " + max);
        Debug.Log("Minimum: " + min);
        Debug.Log("Is your number higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    // Use for stuff that happen on instant reaction
    void Update()
    {
        // Detect when the up arrow key is pressed down
        // https://docs.unity3d.com/ScriptReference/KeyCode.UpArrow.html
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        // Detect when the down arrow key is pressed down
        // https://docs.unity3d.com/ScriptReference/KeyCode.DownArrow.html
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        // Detect when the Return key is pressed down
        // https://docs.unity3d.com/ScriptReference/KeyCode.Return.html
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genious!");
            StartGame();
        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number higher or lower than " + guess + "?");
    }
}
