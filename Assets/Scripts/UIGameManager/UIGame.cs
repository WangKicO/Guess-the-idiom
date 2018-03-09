using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIGame  {

    //UI物体对象
    public GameObject UIObj;

    //UI名字
    public string Name
    {
        get {return UIObj.name; }
    }
    //UI是否显示
    public bool Visible
    {
        get { return UIObj.activeInHierarchy; }
        set { UIObj.SetActive(value); }
    }
    //构建UI
    public UIGame(string name)
    {
        UIObj = GameObject.Instantiate(Resources.Load("UI/" + name)) as GameObject;
        if (UIObj != null)
        {
            UIObj.name = name;
            UIObj.AddComponent(System.Type.GetType(name + "Handler"));
            UIObj.SetActive(false);

        }
    }
}
