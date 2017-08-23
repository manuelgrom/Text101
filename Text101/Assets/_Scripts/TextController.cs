//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;

    private enum _states
    {
        cell,
        mirror,
        sheets0,
        lock0,
        cellMirror,
        sheets2,
        lock1,
        freedom
    }

    private _states _myState;

    // Use this for initialization
    private void Start()
    {
        _myState = _states.cell;
    }

    // Update is called once per frame
    private void Update()
    {
        print(_myState);
        if (_myState == _states.cell)
        {
            StateCell();
        }
        else if (_myState == _states.mirror)
        {
            StateMirror();
        }
        else if (_myState == _states.sheets0)
        {
            StateSheets0();
        }
        else if (_myState == _states.lock0)
        {
            StateLock0();
        }
        else if (_myState == _states.cellMirror)
        {
            StateCellMirror();
        }
        else if (_myState == _states.sheets2)
        {
            StateSheets2();
        }
        else if (_myState == _states.lock1)
        {
            StateLock1();
        }
        else if (_myState == _states.freedom)
        {
            StateFreedom();
        }
    }

    private void StateFreedom()
    {
        
    }

    private void StateLock1()
    {
        
    }

    private void StateSheets2()
    {
        
    }

    private void StateCellMirror()
    {
       
    }

    private void StateLock0()
    {
        
    }

    private void StateSheets0()
    {
        
    }

    private void StateMirror()
    {
        text.text = "Your lookin at the mirror!\n\n" +
                         "Press S for Sheet, L for Lock, M for Mirror";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StateCell();
        }
    }

    private void StateCell()
    {
        text.text = "Your in a cell!\n\n" +
                        "Press S for Sheet, L for Lock, M for Mirror";

        if (Input.GetKeyDown(KeyCode.S))
        {
            StateCell();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            StateLock();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            StateMirror();
        }
    }

    private void StateLock()
    {
        
    }
}
