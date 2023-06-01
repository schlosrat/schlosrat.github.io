// Decompiled with JetBrains decompiler
// Type: UserInterface.Components.Sliders.KSPRadialProgressBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UserInterface.Components.Sliders
{
  [Obsolete("This has been deprecated in favor of the new UI toolkit which leverages data binding and <class>Extended features.")]
  public class KSPRadialProgressBar : UIValueNumberBinder
  {
    [SerializeField]
    private RectTransform _upperTransform;
    [SerializeField]
    private RectTransform _lowerTransform;
    [SerializeField]
    private float _totalAngle;
    [SerializeField]
    private bool _useDataContexts;
    [SerializeField]
    private float _value;
    private const float HalfCircle = 180f;
    private const float FullCircle = 360f;

    public float TotalAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(float value) => throw null;

    public float FullAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAngle(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPRadialProgressBar() => throw null;
  }
}
