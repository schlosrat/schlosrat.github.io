// Decompiled with JetBrains decompiler
// Type: LoadingBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
