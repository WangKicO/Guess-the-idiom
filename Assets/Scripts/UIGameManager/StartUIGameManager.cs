using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class StartUIGameManager : MonoBehaviour {

    public UIGameManager uimgr;
	void Awake ()
    {
        uimgr = UIGameManager.instance;
	}
    void Start()
    {


        Screen.SetResolution(768, 1024, false);
        uimgr.AddUI(UIName.UIHome, true);
        uimgr.AddUI(UIName.UIMap);
        uimgr.AddUI(UIName.UIStage);
        uimgr.AddUI(UIName.UILevel);


        GameConfig.instance.InitStageInfo();
      
    }
	// Update is called once per frame
	void Update () {
		
	}
}
