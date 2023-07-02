// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumberValueTape
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadNumberValueTape : UIValueBinder<float>
  {
    [Tooltip("The transform to be rotated by the bound value")]
    [SerializeField]
    private RectTransform _dialTransform;
    [SerializeField]
    [Tooltip("Labels to use for display on the dial")]
    private TextMeshProUGUI[] _labels;
    [SerializeField]
    [Tooltip("Degrees of seperation between labels")]
    private float _labelDegreeInterval;
    [Tooltip("The value interval to display between labels")]
    [SerializeField]
    private float _valueInterval;
    [SerializeField]
    private bool _clockwiseRotation;
    [SerializeField]
    private string numberTextFormat;
    [Tooltip("Unit Text Field is optional")]
    [SerializeField]
    private float startSwitchThreshold;
    [SerializeField]
    private UIValue_ReadNumber_TextUnits.UnitEntry[] unitEntryArray;
    private int _offsetUnits;
    private float _lastIntervalValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllLabels(float boundValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLabelText(float boundValue, int labelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDialRotation(float boundValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetStringFromUnitsConverted(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumberValueTape() => throw null;
  }
}
