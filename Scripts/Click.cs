using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class Click : MonoBehaviour
{
    public AdvEngine engine;

    public void onClickAct()
    {
        Debug.Log("クリックされた");

        engine.JumpScenario("1day");
    }


    public  int dayday(){
        int n = 2;
        return n;
    } 
}
