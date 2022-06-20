﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject subCamera;
    void Start()
    {
        // 各カメラオブジェクトを取得
        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");
         
        // サブカメラはデフォルトで無効にしておく
        subCamera.SetActive(false);
    }
 
    public void OnDetective()
    {
        // 各カメラオブジェクトの有効フラグを逆転(true→false,false→true)させる
        mainCamera.SetActive(!mainCamera.activeSelf);
        subCamera.SetActive(!subCamera.activeSelf);
    }
}