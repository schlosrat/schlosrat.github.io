// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_WriteEnum_Button
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding.Core
{
  public class UIValue_WriteEnum_Button : UIValueEnumBinder
  {
    [SerializeField]
    private Button button;
    [Header("MODE")]
    [SerializeField]
    private UIValue_WriteEnum_Button.ButtonMode mode;
    [SerializeField]
    [Header("MODE: Set Value")]
    private string value;
    [Header("MODE: Set Value Index")]
    [SerializeField]
    private int valueIndex;
    [Header("MODE: Add Value Offset")]
    [SerializeField]
    private int valueOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Button_OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteEnum_Button() => throw null;

    private enum ButtonMode
    {
      SetValue,
      SetValueIndex,
      AddValueOffset,
    }
  }
}
