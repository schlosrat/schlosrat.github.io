// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartHeatIndicatorTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class PartHeatIndicatorTracker
  {
    public readonly PartBehavior PartBehavior;
    private IndicatorHeatWarning _heatWarningIndicator;

    public Vector3 PartScreenPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3 PartViewportPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float PartTemperatureRatio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartHeatIndicatorTracker(PartBehavior partBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateData(Camera viewCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateTemperatureRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequestHeatWarningIndicator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseHeatWarningIndicator() => throw null;
  }
}
