using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SearchTool : MonoBehaviour
{
    public GameObject MainSearch;
    public GameObject SquirrelSearch;
    public GameObject GuineafowlSearch;
    public GameObject Buttons;
    public InputField SearchInstance;
    public Button PrevButton;
    public Button NextButton;
    
    
    public bool isFirstPannel;
    public bool squirToSearch;
    public bool pintToSearch;

    private Stack<Command> Commands = new Stack<Command>();

    void Update()
    {
        if (SearchInstance.text == "pintade" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "Pintade" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "guineafowl" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "Guineafowl" && Input.GetKeyDown(KeyCode.Return))
        {
            SearchInstance.text = "";
            MainSearch.gameObject.SetActive(false);
            GuineafowlSearch.gameObject.SetActive(true);
            Buttons.gameObject.SetActive(true);
            pintToSearch = true;
        } else if (SearchInstance.text == "écureuil" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "ecureuil" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "squirrel" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "Ecureuil" && Input.GetKeyDown(KeyCode.Return) || SearchInstance.text == "Squirrel" && Input.GetKeyDown(KeyCode.Return))
        {
            SearchInstance.text = "";
            MainSearch.gameObject.SetActive(false);
            SquirrelSearch.gameObject.SetActive(true);
            Buttons.gameObject.SetActive(true);
            squirToSearch = true;
        } else
        {
            isFirstPannel = true;
        }
    }
    public void previousButton()
    {
        Command command = new PreviousPage(SquirrelSearch, MainSearch, GuineafowlSearch, squirToSearch, isFirstPannel, pintToSearch);
        command.Do();
        Commands.Push(command);
    }

    public void nextButton()
    {
        if (Commands.Count > 0)
        {
            Command command = Commands.Pop();
            command.Undo();
        }
    }
}