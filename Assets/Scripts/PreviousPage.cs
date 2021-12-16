using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 

public class PreviousPage : Command
{
    
    public PreviousPage(GameObject squirPannel, GameObject searchPannel, GameObject pintPannel, bool squirToSearch, bool isFirstPannel, bool pintToSearch) : base(squirPannel, searchPannel, pintPannel, isFirstPannel, squirToSearch, pintToSearch) { }

    public override void Do()
    {
        CurrentSquirPannel.SetActive(false);
        SearchPannel.SetActive(true);
        PintPannel.SetActive(false);
    }

    public override void Undo()
    {

        if (IsFirstPannel == true)
        {
            CurrentSquirPannel.SetActive(false);
            SearchPannel.SetActive(true);
            PintPannel.SetActive(false);
        }

        if (SquirToSearch == true)
        {
            CurrentSquirPannel.SetActive(true);
            SearchPannel.SetActive(false);
            PintPannel.SetActive(false);
        }

        if (PintToSearch == true)
        {
            CurrentSquirPannel.SetActive(false);
            SearchPannel.SetActive(false);
            PintPannel.SetActive(true);
        }
        
        /*CurrentSquirPannel.SetActive(true);
        SearchPannel.SetActive(false);
        PintPannel.SetActive(false);*/
    }
}
