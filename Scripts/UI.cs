using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class UI : MonoBehaviour
{
    public AdvEngine engine;
    //オブジェクトの設定
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject detective;
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    public GameObject q5;
    public GameObject tutorial;
    public GameObject protect;
    bool BM=true;
    int point;

    public void Update()
    {
        //表示のコントロール
        if (BM==true)
        {
            btn1.SetActive(false);
            btn2.SetActive(true);
            btn3.SetActive(false);
            btn4.SetActive(true);
            detective.SetActive(true);
            protect.SetActive(true);
            q1.SetActive(false);
            q2.SetActive(false);
            q3.SetActive(false);
            q4.SetActive(false);
            q5.SetActive(false);
            tutorial.SetActive(false);
        }
        else
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
            btn4.SetActive(false);
            detective.SetActive(false);
            protect.SetActive(false);
        }
    }

    public void TRUE()
    {
        BM = true;
        Debug.Log("hit");
    }

    public void FALSE()
    {
        BM = false;
        Debug.Log("hit");
    }

    public void Detective()
    {
        //パラメータが初期化されているか
        if (!engine.Param.IsInit) return;
        //パラメーターの取得
        //複数同時に取得できないため、個々で取得
        var obj = engine.Param.GetParameter("qtemp");
        int temp = engine.Param.GetParameterInt("qtemp");
        obj = engine.Param.GetParameter("qsky");
        int sky = engine.Param.GetParameterInt("qsky");
        obj = engine.Param.GetParameter("qlost");
        int lost = engine.Param.GetParameterInt("qlost");
        obj = engine.Param.GetParameter("qlife");
        int life = engine.Param.GetParameterInt("qlife");
        BM = false;
        q1.SetActive(true);
        if(temp==1)
        {
            q2.SetActive(true);
        }
        if(sky==1)
        {
            q3.SetActive(true);
        }
        if(lost==1)
        {
            q4.SetActive(true);
        }
        if(life==1)
        {
            q5.SetActive(true);
        }
        tutorial.SetActive(true);
        btn3.SetActive(true);
    }
}
