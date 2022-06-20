using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class DayManager : MonoBehaviour
{
    public AdvEngine engine;

    public Text daytext;


    void Update() //日付を表示する
    {
        //パラメータが初期化されているか
        if (!engine.Param.IsInit) return;
        //パラメーターの取得
        var obj = engine.Param.GetParameter("day");
        int point = engine.Param.GetParameterInt("day");
        //ベッドが押されたら
        daytext.text = point.ToString("d");
        
        //if(daytext.text == "20")

    }

    public void DaySkip()
    {
        //Excelデータからdayの制御
        engine.JumpScenario("sleep");
    }
}
