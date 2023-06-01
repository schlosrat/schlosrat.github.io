// Decompiled with JetBrains decompiler
// Type: LoadingBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using I2.Loc;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
  [SerializeField]
  private RectTransform loadingBarContainer;
  [SerializeField]
  private RectTransform loadingBarProgress;
  [SerializeField]
  private TMP_Text loadingText;
  [SerializeField]
  private TMP_Text statusText;
  [SerializeField]
  private TMP_Text tipsText;
  private LanguageSourceData tipsSource;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SourceDataInit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTips() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetText(string s) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPercentComplete(float f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LoadingBar() => throw null;
}
