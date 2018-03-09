using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIPasspad : UIHandler {

    public UILabel explain1;
    public UILabel explain2;
    public UILabel title_Label;

    public UIButton Next_Btn;

    System.Action _Action;
    //public delegate void OnComponent();
    //public event OnComponent onComponent;

    void Awake ()
    {
        explain1 = GetComponentByName<UILabel>("explain 1");
        explain2 = GetComponentByName<UILabel>("explain 2");
        title_Label = GetComponentByName<UILabel>("title_Label");
        Next_Btn = GetComponentByName<UIButton>("Next");
        EventDelegate.Add(Next_Btn.onClick, OnNextClick);
    }
    void OnNextClick()
    {

            if (_Action != null)
            {
                _Action();
            }
            GameObject.Destroy(this.gameObject); 
    }

    public void ShowPassPad(string text1,string text2,string text3, System.Action action = null )
    {
        explain1.text = text1;
        explain2.text = text2;
        title_Label.text = text3;
        this._Action  += action;
    }
	
	
}
