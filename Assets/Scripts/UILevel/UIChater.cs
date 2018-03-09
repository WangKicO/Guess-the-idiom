using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIChater : MonoBehaviour {

    private UILabel _chaterLabel;   //点击的字体
    public UILabel ChaterLabel
    {
        get { if (_chaterLabel == null)
            {
                _chaterLabel = this.GetComponentInChildren<UILabel>();
            }
            return _chaterLabel;
        }
    }
   
    public string text  //点击的文本内容
    {
        get { return ChaterLabel.text; }
        set { ChaterLabel.text = value; }
            
       
    }

    void OnClick()
    {
       
        for (int i = 0; i < UIResultListHandler.instance.Result_Labels.Length; i++)
        {
            if (UIResultListHandler.instance.Result_Labels[i].text == "")
            {
                UIResultListHandler.instance.Result_Labels[i].text = this.text;
                this.gameObject.SetActive(false);
                break;
            }
        }

        if (UIChaterManager.instance.ChaterList.Count >= 4)
        {
            return;
        }
        else
        {
            UIChaterManager.instance.ChaterList.Add(this);
        }
        UIChaterManager.instance.OnSubmitChar();
        
    } 


}
