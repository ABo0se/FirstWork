using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartProGram : MonoBehaviour
{
    public GameObject TempGroup;
    public GameObject RulerGroup;
    // Start is called before the first frame update
    void Start()
    {
        TempGroup.SetActive(true);
        RulerGroup.SetActive(false);
    }
}
