using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class Detective : MonoBehaviour
{
    public AdvEngine engine;
    //各推理
    public void DayandNight()
    {
        engine.JumpScenario("dayandnight");
    }

    public void Temperature()
    {
        engine.JumpScenario("temperature");
    }

    public void Sky()
    {
        engine.JumpScenario("sky");
    }

    public void GetLost()
    {
        engine.JumpScenario("getlost");
    }

    public void FirePlace()
    {
        engine.JumpScenario("life");
    }

    public void Tutorial()
    {
        engine.JumpScenario("tutorial");
    }
}
