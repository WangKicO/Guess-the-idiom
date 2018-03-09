using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIMapHandler : UIHandler {

    // Use this for initialization

    public UIButton btn_back;
	void Start () {

        btn_back = GetByName("back_Btn").GetComponent<UIButton>();
        EventDelegate.Add(btn_back.onClick, OnBtnBackClick);

        UpdataShow();

        UIGameManager.instance.onUpdata += UpdataShow;
      
        

	}
    
    void UpdataShow()
    {
        UIHouseItem[] items = GetComponentsInChildren<UIHouseItem>();
        for (int i = 0; i < items.Length; i++)
        {
            items[i].InitHouseSprite(i, i < GameConfig.instance.MaxStageCount ? false : true);
        }

    }
    void OnBtnBackClick()
    {
        UIGameManager.instance.ShowUI(UIName.UIHome);
        UIGameManager.instance.HideUI(UIName.UIMap);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
