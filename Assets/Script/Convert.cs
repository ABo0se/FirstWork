using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Convert : MonoBehaviour
{
    //public TextMeshProUGUI TextInputresult;
    public TextMeshProUGUI TextOutputresult;
    public Button ConvertScript;
    public TMP_InputField datainput1;
    public TMP_Dropdown firstcontentTempdropdown;
    public TMP_Dropdown secondcontentTempdropdown;
    public TMP_Dropdown firstcontentLengthdropdown;
    public TMP_Dropdown secondcontentLengthdropdown;
    double inputresult, inputmodified, outputresult;
    int checkerror;
    string firstdropdown, seconddropdown, actualresult;
    // Start is called before the first frame update

    public void ConvertTemp()
    {
        if (firstdropdown == "Kevin")
        {
            inputmodified = inputresult;
        }
        else if (firstdropdown == "Celcius")
        {
            inputmodified = inputresult + 273;
        }
        else if (firstdropdown == "Fahrenheit")
        {
            inputmodified = (inputresult + 459.67) * 5 / 9;
        }
        else if (firstdropdown == "Romer")
        {
            inputmodified = (inputresult * 1.25) + 273;
        }
        if (inputmodified >= 0)
        {
            if (seconddropdown == "Kevin")
            {
                outputresult = inputmodified;
            }
            else if (seconddropdown == "Celcius")
            {
                outputresult = inputmodified - 273;
            }
            else if (seconddropdown == "Fahrenheit")
            {
                outputresult = (inputmodified * 1.8) - 459.67;
            }
            else if (seconddropdown == "Romer")
            {
                outputresult = (inputmodified - 273) * 0.8;
            }
            Result();
        }
        else
        {
            checkerror = 1;
            Result();
        }
    }
    public void ConvertLength()
    {
        if (firstdropdown == "Millimeter")
        {
            inputmodified = inputresult;
        }
        else if (firstdropdown == "Centimeter")
        {
            inputmodified = inputresult * 10;
        }
        else if (firstdropdown == "Meter")
        {
            inputmodified = inputresult * 1000;
        }
        else if (firstdropdown == "Kilometer")
        {
            inputmodified = inputresult * 1000000;
        }
        else if (firstdropdown == "Inch")
        {
            inputmodified = inputresult * 25.4;
        }
        else if (firstdropdown == "Foot")
        {
            inputmodified = inputresult * 304.8;
        }
        else if (firstdropdown == "Yard")
        {
            inputmodified = inputresult * 914.4;
        }
        else if (firstdropdown == "Mile")
        {
            inputmodified = inputresult * 1609344;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        if (seconddropdown == "Millimeter")
        {
            outputresult = inputmodified;
        }
        else if (seconddropdown == "Centimeter")
        {
            outputresult = inputmodified / 10;
        }
        else if (seconddropdown == "Meter")
        {
            outputresult = inputmodified / 1000;
        }
        else if (seconddropdown == "Kilometer")
        {
            outputresult = inputmodified / 1000000;
        }
        else if (seconddropdown == "Inch")
        {
            outputresult = inputmodified / 25.4;
        }
        else if (seconddropdown == "Foot")
        {
            outputresult = inputmodified / 304.8;
        }
        else if (seconddropdown == "Yard")
        {
            outputresult = inputmodified / 914.4;
        }
        else if (seconddropdown == "Mile")
        {
            outputresult = inputmodified / 1609344;
        }
        Result();
    }
    public void GetInputOnClickHandler()
    {
        checkerror = 0;
        inputresult = double.Parse(datainput1.text);
        if (WorkMode.workmode == 1)
        {
            firstdropdown = firstcontentTempdropdown.options[firstcontentTempdropdown.value].text;
            seconddropdown = secondcontentTempdropdown.options[secondcontentTempdropdown.value].text;
            ConvertTemp();
        }
        else if (WorkMode.workmode == 2)
        {
            if (inputresult >= 0)
            {
                firstdropdown = firstcontentLengthdropdown.options[firstcontentLengthdropdown.value].text;
                seconddropdown = secondcontentLengthdropdown.options[secondcontentLengthdropdown.value].text;
                ConvertLength();
            }
            else
            {
                checkerror = 1;
                Result();
            }
        }
    }
    public void Result()
    {
        if (checkerror == 0)
        {
            actualresult = outputresult.ToString("F2") + " " + seconddropdown;
        }
        else
        {
            actualresult = "Error! Please Try again.";
        }
        TextOutputresult.text = actualresult;
    }
    public void Reset()
    {
        TextOutputresult.text = "-";
        datainput1.text = "Enter Number...";
    }
    public void ResetOnlyAnswer()
    {
        TextOutputresult.text = "-";
    }
}