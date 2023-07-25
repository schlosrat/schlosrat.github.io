// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.PerformanceChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public abstract class PerformanceChart
  {
    protected static Color[] wheelChartColors;

    public VehicleBase vehicle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DataLogger dataLogger
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ReferenceSpecs reference
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string Title() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ResetView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SetupChannels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RecordData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PerformanceChart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PerformanceChart() => throw null;
  }
}
