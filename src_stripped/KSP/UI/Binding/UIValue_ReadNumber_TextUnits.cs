// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_TextUnits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [Tooltip("Optional. Add loc path here for units to be divided by or just the unit if loc is not required.")]
    [SerializeField]
    private string divisorUnit;
    [SerializeField]
    private float startSwitchThreshold;
    [SerializeField]
    private UIValue_ReadNumber_TextUnits.UnitEntry[] unitEntryArray;
    [Tooltip("Note that using the rounding options will override the numberTextFormat")]
    [Header("Decimal rounding options")]
    [SerializeField]
    private bool _roundValue;
    [SerializeField]
    private int _decimalPlaces;
    [SerializeField]
    private bool _forceDecimalPlaces;
    [SerializeField]
    private bool _roundAllDecimalPlacesOnLargeRoundedNumbers;
    [SerializeField]
    private int _roundAllDecimalPlacesForNumbersOver;
    [SerializeField]
    private bool _useScientificNotationOnLargeRoundedNumbers;
    [SerializeField]
    private int _useScientificNotationForNumbersOver;
    private bool _forceConversion;
    private int _forceConvertUnitEntryIndex;
    private string _roundedFormatString;
    private string _scientificNotationFormatString;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

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
    private string Round(double value) => throw null;

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
