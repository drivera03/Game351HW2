using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour 
{ 
    public GameObject[] characters; // Array to hold character prefabs 
    private int currentCharacter = 0; 
 
    void Start() 
    { 
        // Ensure only the first character is enabled at the start
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].gameObject.SetActive(i == currentCharacter);
        }
    } 
 
    void Update() 
    { 
        // Check for input to switch character
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCharacter();
        }
    } 
 
    void SwitchCharacter() 
    { 
        // Disable the current camera
        characters[currentCharacter].gameObject.SetActive(false);

        // Increment the camera index, wrapping around if necessary
        currentCharacter = (currentCharacter + 1) % characters.Length;

        // Enable the new current camera
        characters[currentCharacter].gameObject.SetActive(true);
    } 
} 
