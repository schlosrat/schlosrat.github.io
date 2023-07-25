// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteNumber_Field
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_WriteNumber_Field : UIValueBinder
  {
    [SerializeField]
    private TMP_InputField numberField;
    [SerializeField]
    [Header("Optional, if set formats as: \"{0:numberFormat}\"")]
    private string numberFormat;
    [SerializeField]
    [Header("Configurations")]
    private bool submitEachKeyPress;
    [SerializeField]
    private bool valueChangeDeselects;
    [SerializeField]
    private bool autoRefreshOnSubmit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual string GetNumberAsString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool TryParseNumberFromString(string toParse, out object parsed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetValueFromString(string newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnFieldEditEnd(string newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnFieldValueChanged(string newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteNumber_Field() => throw null;
  }
}
