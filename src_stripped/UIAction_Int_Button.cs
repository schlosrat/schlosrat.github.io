// Decompiled with JetBrains decompiler
// Type: UIAction_Int_Button
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIAction_Int_Button : UIActionBinder
{
  public Button button;
  public List<UIAction_Int_Button.IntArg> intArgs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnButtonLeftDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private object[] GetArgs(IDataContextReadonly context) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIAction_Int_Button() => throw null;

  [Serializable]
  public struct IntArg
  {
    [Header("0 if all sources not set")]
    [FormerlySerializedAs("valueKey")]
    public string valueSourceKey;
    [FormerlySerializedAs("valueSourceTextBox")]
    [FormerlySerializedAs("intTextBox")]
    public TMP_InputField valueSourceInputField;
    [FormerlySerializedAs("intTextBox")]
    public SliderExtended valueSourceSlider;
    [Header("if non-zero will be added to value")]
    public int staticValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetArg(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int? GetContextValue(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int? GetTextValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int? GetSliderValue() => throw null;
  }
}
