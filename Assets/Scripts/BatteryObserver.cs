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
    /// <summary>
    /// バッテリー残量取得
    /// </summary>
    /// <returns>バッテリー残量</returns>
    [DllImport("__Internal")]
    private static extern float GetBatteryLevel();

    /// <summary>
    /// 充電中？
    /// </summary>
    /// <returns>充電中ならtrue</returns>
    [DllImport("__Internal")]
    private static extern bool IsBatteryCharging();
#endif

    void Update()
    {
#if UNITY_IOS && !UNITY_EDITOR
        string DispText = string.Format("BatteryLevel:{0}", GetBatteryLevel());
        if (IsBatteryCharging())
        {
            DispText += "(充電中)";
        }
        DisplayText.text = DispText;
#endif
    }
}
