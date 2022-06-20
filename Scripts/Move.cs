using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class Move : MonoBehaviour
{
    public GameObject mainc;
    /*public GameObject UIc;
    public GameObject spritec;*/
    public AdvEngine engine;
    public int spot=0;

    public void Update()
    {
        //パラメータが初期化されているか
        if (!engine.Param.IsInit) return;
        //パラメーターの取得
        var obj = engine.Param.GetParameter("spot");
        spot = engine.Param.GetParameterInt("spot");
        /*if (engine.IsEndScenario)
        {

        }*/

        //カメラの移動
        if(spot==0)
        {
            mainc.transform.localPosition = new Vector3(0, 0, -10);
        }
        else if(spot==1)
        {
            mainc.transform.localPosition = new Vector3(0, -15, -10);
        }
        else if(spot==2)
        {
            mainc.transform.localPosition = new Vector3(25, 0,-10);
        }
        else if(spot==3)
        {
             mainc.transform.localPosition = new Vector3(25, -15,-10);
        }
    }

    public void MoveCamera()
    {
        engine.JumpScenario("Move");
    }
}
