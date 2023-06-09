﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIData_DemoVessel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI.Binding
{
  public class UIData_DemoVessel : UIDataDemoVesselBinder
  {
    [SerializeField]
    private float AnimationDuration;
    [SerializeField]
    private Vector3 OffsetWhenDisabled;
    [SerializeField]
    [Header("Bound UI Elements")]
    private UIValueBinder MapToggle;
    [SerializeField]
    private UIValueBinder GuidText;
    [SerializeField]
    private UIValueNumberBinder AltitudeSlider;
    [SerializeField]
    private UIValueNumberBinder VelocitySlider;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RedrawOnIsBoundChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIData_DemoVessel() => throw null;
  }
}
