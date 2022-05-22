using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject instructionMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackMainMenu()
    {
        instructionMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
