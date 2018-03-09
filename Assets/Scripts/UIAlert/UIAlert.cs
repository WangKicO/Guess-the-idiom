using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIAlert : UIHandler {

    private UILabel _title;
    public UILabel Title
    {
        get { if (_title == null)
            {
                _title = GetByName("title").GetComponent<UILabel>();
            }
            return _title;

        }
    }
    private UILabel _text;
    public UILabel Text
    {
        get
        {
            if (_text == null)
            {
                _text = GetByName("text").GetComponent<UILabel>();
            }
            return _text;

        }
    }

    public UIButton btnOk;
    
    private void Start()
    {
        btnOk = GetByName("btnOk").GetComponent<UIButton>() ;
        EventDelegate.Add(btnOk.onClick, OnBtnOkClick);

    }
    public System.Action _Action;

    void OnBtnOkClick()
    {
        if (_Action != null)
        {
            _Action();
        }
        Destroy(this.gameObject);
    }
    public void ShowAlert(string title, string text,System.Action action = null)
    {
        this.Title.text = title;
        this.Text.text = text;
        _Action += action;
    }
		
	
}
