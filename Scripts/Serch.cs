using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class Serch : MonoBehaviour
{
    public AdvEngine engine;

    private int startlife=10;

    public void Danro()
    {
        //パラメータが初期化されているか
        if (!engine.Param.IsInit) return;
        //パラメーターの取得
        var obj = engine.Param.GetParameter("qlife");
        int life = engine.Param.GetParameterInt("qlife");

        engine.JumpScenario("danro");
        if(life-startlife >=10)
        {
            engine.JumpScenario("danro2");
        }
        startlife = life;
    }

    public void Snow()
    {
        engine.JumpScenario("snow");
    }
    public void Pod()
    {
        engine.JumpScenario("pod");
    }
    public void IllustA()
    {
        engine.JumpScenario("illustA");
    }
    public void IllustB()
    {
        engine.JumpScenario("illustB");
    }
    public void IllustC()
    {
        engine.JumpScenario("illustC");
    }
    public void IllustD()
    {
        engine.JumpScenario("illustD");
    }
}
