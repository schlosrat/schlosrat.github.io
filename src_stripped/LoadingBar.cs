// Decompiled with JetBrains decompiler
// Type: LoadingBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using I2.Loc;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
  private const string LOADING_TIP_SOURCE_ASSET_NAME = "I2Languages_LoadingTips (I2.Loc.LanguageSourceAsset)";
  [SerializeField]
  private RectTransform loadingBarContainer;
  [SerializeField]
  private RectTransform loadingBarProgress;
  [SerializeField]
  private TMP_Text statusText;
  [SerializeField]
  private TMP_Text tipsText;
  [SerializeField]
  private double minimumSecondsPerTip;
  private LanguageSourceData _tipsSource;
  private double _lastTipChangeTime;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SourceDataInit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ShuffleLoadingTip() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetText(string s) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPercentComplete(float f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LoadingBar() => throw null;
}
