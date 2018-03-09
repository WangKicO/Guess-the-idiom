using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==!==--dzy
public class UIHandler : MonoBehaviour {

    //通过名字寻找子物体
    protected GameObject GetByName(string name)
    {
        Transform[] trans = GetComponentsInChildren<Transform>(true);
        for (int i = 0; i < trans.Length; i++)
        {
            if (trans[i].name == name)
            {
                return trans[i].gameObject;
            }
        }
        return null;
    }

    // 泛型函数
    protected T GetComponentByName<T>(string name) where T : MonoBehaviour
    {
        GameObject go = GetByName(name);
        if (go == null)
        {
            return null;
        }
        return go.GetComponent<T>();
    }
}
