// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteColor_AlphaPercentField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_WriteColor_AlphaPercentField : UIValueBinder<Color>
  {
    [SerializeField]
    private TMP_InputField colorAField;
    [SerializeField]
    [Header("Configurations")]
    private bool submitEachKeyPress;
    [SerializeField]
    private bool valueChangeDeselects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleFieldUpdate(TMP_InputField field, bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ValidateAndParseField(TMP_InputField field, float curVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RedrawFieldValue(TMP_InputField field, float curVal) => throw null;

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
    public UIValue_WriteColor_AlphaPercentField() => throw null;
  }
}
