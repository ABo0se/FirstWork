using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkMode : MonoBehaviour
{
    public static int workmode;

    void Start()
    {
        workmode = 1;
    }

    public void ClickRuler()
    {
        workmode = 2;
    }
    public void ClickTemp()
    {
        workmode = 1;
    }
    public void Reset()
    {

    }
}
