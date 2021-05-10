using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

/// <summary>
/// バッテリー監視
/// </summary>
public class BatteryObserver : MonoBehaviour
{
    /// <summary>
    /// 表示用テキストフィールド
    /// </summary>
    [SerializeField]
    Text DisplayText = null;

#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern int TestInt();
#endif

    void Start()
    {
#if UNITY_IOS && !UNITY_EDITOR
        DisplayText.text = string.Format("Test:{0}", TestInt());
#endif
    }
}
