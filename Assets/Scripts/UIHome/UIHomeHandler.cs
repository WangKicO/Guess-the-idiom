using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIHomeHandler : UIHandler {

    List<GameObject> Alerts = new List<GameObject>();


    public string[] btnNames = { "Normal", "PK", "Story", "Settings" };

    private void Start()
    {
        for (int i = 0; i < btnNames.Length; i++)
        {
            UIEventListener.Get(GetByName(btnNames[i])).onClick = OnBtnClick;
        }

    }

    void OnBtnClick(GameObject go)
    {
        switch (go.name)
        {
            case "Normal":
                // 点击闯关按钮              
                UIGameManager.instance.ShowUI(UIName.UIMap);
                UIGameManager.instance.HideUI(UIName.UIHome);
                break;
            case "PK":
                // 点击PK
                UIAlertManager.instance.CreateAlert(this.gameObject, "UIAlert", null, "消息", go.name + "模式正在开发中");
                break;
            case "Story":
                // 点击故事
                UIAlertManager.instance.CreateAlert(this.gameObject, "UIAlert",null, "消息", go.name + "模式正在开发中");
                break;
            case "Settings":
                // to do点击 设置
               // UIAlertManager.instance.CreateAlert(this.gameObject, "UISettings", "消息", go.name + "模式正在开发中");
                break;


        }
    }

}
