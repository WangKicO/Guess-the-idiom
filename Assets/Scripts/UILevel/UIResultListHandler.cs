using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIResultListHandler : UIHandler {

    public UILabel[] Result_Labels = new UILabel[4];
    public GameObject go;

    public static UIResultListHandler instance;

    private void Awake()
    {
        instance = this;
    }
    void Start () {
        for (int i = 0; i < Result_Labels.Length; i++)
        {
            go = GetByName("Result_bg" + i);
            UIEventListener.Get(go).onClick = OnBtnClick;
            Result_Labels[i] = go.GetComponentInChildren<UILabel>();
        }

    }
    void OnBtnClick(GameObject go)
    {
        UILabel selectLabel = go.GetComponentInChildren<UILabel>();
        if (selectLabel.text == "")
        {
            return;
        }
        else
        {
            List<UIChater> tempList = UIChaterManager.instance.ChaterList;
            for (int i = 0; i < tempList.Count; i++)
            {
                //当前的文本
                if (tempList[i].text == selectLabel.text)
                {
                    tempList[i].gameObject.SetActive(true);
                    selectLabel.text = "";
                    UIChaterManager.instance.ChaterList.Remove(tempList[i]);
                    break;
                }
            }
             
        }
         
    }
    // Update is called once per frame
    void Update () {
		
	}
}
