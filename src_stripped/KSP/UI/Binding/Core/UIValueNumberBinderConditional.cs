// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueNumberBinderConditional
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  [DisallowMultipleComponent]
  public abstract class UIValueNumberBinderConditional : UIValueBinder<double>
  {
    [Space]
    public bool resultIfKeyNotFound;
    [Header("Conditional to run on Value, X and optionally Y")]
    public UIValueNumberBinderConditional.Operator conditionalOperator;
    [Header("X = Static + (key value or 0)")]
    public string valueXKey;
    public double valueXStatic;
    [Header("Y = Static + (key value or 0)")]
    public string valueYKey;
    public double valueYStatic;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void HandleConditionalResult(bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EvaluateConditional(double value, IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double? GetKeyNumberValue(string key, IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool EvaluateConditionalOperator(
      double value,
      UIValueNumberBinderConditional.Operator oper,
      double xValue,
      double yValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIValueNumberBinderConditional() => throw null;

    public enum Operator
    {
      IsEqualToX,
      IsNotEqualToX,
      IsLessThanX,
      IsLessThanOrEqualToX,
      IsGreaterThanX,
      IsGreaterThanOrEqualToX,
      IsBetweenXAndYInclusive,
      IsBetweenXAndYExclusive,
      IsOutsideXAndYInclusive,
      IsOutsideXAndYExclusive,
      IsCloserThanXFromYInclusive,
      IsCloserThanXFromYExclusive,
      IsFurtherThanXFromYInclusive,
      IsFurtherThanXFromYExclusive,
    }
  }
}
