using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class talk : MonoBehaviour
{
    public AdvEngine engine;
    
    //文字列の取得
    public Text count;
    string get;
    

    void Start()
    {
        //engine.JumpScenario("Re");
    }

    void Update()
    {
        get=count.text.ToString();
    }

    public void OnClick()
    {
        switch(get)
        {
            case "1":
                engine.JumpScenario("1day");
                break;
            case "2":
                engine.JumpScenario("2day");
                break;
            case "3":
                engine.JumpScenario("3day");
                break;
            case "4":
                engine.JumpScenario("4day");
                break;
            case "5":
                engine.JumpScenario("5day");
                break;
            case "6":
                engine.JumpScenario("6day");
                break;
            case "7":
                engine.JumpScenario("7day");
                break;
            case "8":
                engine.JumpScenario("8day");
                break;
            case "9":
                engine.JumpScenario("9day");
                break;
            case "10":
                engine.JumpScenario("10day");
                break;
            case "11":
                engine.JumpScenario("11day");
                break;
            case "12":
                engine.JumpScenario("12day");
                break;
            case "13":
                engine.JumpScenario("13day");
                break;
            case "14":
                engine.JumpScenario("14day");
                break;
            case "15":
                engine.JumpScenario("15day");
                break;
            case "16":
                engine.JumpScenario("16day");
                break;
            case "17":
                engine.JumpScenario("17day");
                break;
            case "18":
                engine.JumpScenario("18day");
                break;
            case "19":
                engine.JumpScenario("19day");
                break;
            case "20":
                engine.JumpScenario("20day");
                break;
        }
        
    }
}
