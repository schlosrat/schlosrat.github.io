// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_TextUnits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_TextUnits : 
    UIValueBinder<double>,
    IUIValueNumberBindable,
    IUIValueBindable
  {
    [SerializeField]
    private TMP_Text numberText;
    [SerializeField]
    private string numberTextFormat;
    [Tooltip("Unit Text Field is optional")]
    [SerializeField]
    private TMP_Text unitText;
    [SerializeField]
    private float startSwitchThreshold;
    [SerializeField]
    private UIValue_ReadNumber_TextUnits.UnitEntry[] unitEntryArray;
    private bool _forceConversion;
    private int _forceConvertUnitEntryIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextToMatchUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueNumberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceConversion(bool forceConvert, int unitEntryIndex = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_TextUnits() => throw null;

    [Serializable]
    public struct UnitEntry
    {
      public float unitMultiplier;
      [Tooltip("Add loc path here for units or just the unit if loc is not required.")]
      [Header("The loc term can also be used here")]
      public string unitValue;
      public string numberTextFormat;
      public bool dontTruncateValue;
      public float switchThresholdMultiplier;
    }
  }
}
