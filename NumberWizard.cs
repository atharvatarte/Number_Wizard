using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int min = 1;
        int max = 1000;
        int guess = 500;

    void Start()
    
    {
        StartGame();
    }

    void StartGame()

    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome To Number Wizard Game...");
        Debug.Log("Pick a number in your mind and dont tell anyone");
        Debug.Log("Maximum you can pick is " + max);
        Debug.Log("Minimum you can pick is " + min);
        Debug.Log("Tell if Number is higher or lower than the " + guess);
        Debug.Log("If Higher Press UP , If Lower Press Down , If Correct Press Enter");
        max = max + 1;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your Number is " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number Higher, Lower or Equal to " + guess);
    }
}
