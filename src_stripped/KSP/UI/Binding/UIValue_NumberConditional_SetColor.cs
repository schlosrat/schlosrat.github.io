// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NumberConditional_SetColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_NumberConditional_SetColor : UIValueBinder<double>
  {
    [SerializeField]
    private UIValue_NumberConditional_SetColor.Operator _conditionalOperator;
    [SerializeField]
    private double _comparisonValue;
    [SerializeField]
    private bool _resultIfKeyNotFound;
    [SerializeField]
    private Graphic _target;
    [SerializeField]
    private Color _colorIfTrue;
    [SerializeField]
    private Color _colorIfFalse;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool EvaluateCondition(
      double boundValue,
      double conditionalValue,
      UIValue_NumberConditional_SetColor.Operator oper)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NumberConditional_SetColor() => throw null;

    public enum Operator
    {
      IsLessThan,
      IsLessThanOrEqualTo,
      IsGreaterThan,
      IsGreaterThanOrEqualTo,
    }
  }
}
