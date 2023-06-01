// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteColor_HexField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_WriteColor_HexField : UIValueBinder<Color>
  {
    [SerializeField]
    private TMP_InputField colorHexField;
    [SerializeField]
    [Header("Configurations")]
    private bool submitEachKeyPress;
    [SerializeField]
    private bool valueChangeDeselects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleFieldUpdate(TMP_InputField field, bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color ValidateAndParseField(TMP_InputField field, string curVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RedrawFieldValue(TMP_InputField field, string curVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetValueFromFields() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnFieldEditEnd(string _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnFieldValueChanged(string _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteColor_HexField() => throw null;
  }
}
