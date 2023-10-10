using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    string _name;
    float _totalWin;

    public float GetTotalWin()
    {
        return _totalWin;
    }

    public void SetTotalWin(float winAmount)
    {
        _totalWin = winAmount;
    }
    public string getName()
    {
        return _name;
    }

    public void setName(string newName)
    {
        _name = newName;
    }
}