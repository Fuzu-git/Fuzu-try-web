using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Command
{
    protected GameObject CurrentSquirPannel;
    protected GameObject SearchPannel;
    protected GameObject PintPannel;
    
    protected bool IsFirstPannel;
    protected bool SquirToSearch;
    protected bool PintToSearch;
    protected Command(GameObject squirPannel, GameObject searchPannel, GameObject pintPannel, bool isFirstPannel, bool squirToSearch, bool pintToSearch)
    {
        CurrentSquirPannel = squirPannel;
        SearchPannel = searchPannel;
        PintPannel = pintPannel;

        IsFirstPannel = isFirstPannel;
        SquirToSearch = squirToSearch;
        PintToSearch = pintToSearch;
    }

    public abstract void Do();

    public abstract void Undo();
}
