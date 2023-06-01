// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueNumberBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public abstract class UIValueNumberBinder : 
    UIValueBinder<double>,
    IUIValueNumberBindable,
    IUIValueBindable
  {
    [SerializeField]
    private double valueMappedMin;
    [SerializeField]
    private double valueMappedMax;
    [SerializeField]
    private double valueMappedStep;
    [SerializeField]
    private bool valueMappedUseStep;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    public UIValueNumberRange NumberRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected double CurValueMapped
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected float CurValue01
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueNumberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetMappedValueRange(
      double min,
      double max,
      double rangeStep,
      bool shouldRedraw = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIValueNumberBinder() => throw null;
  }
}
