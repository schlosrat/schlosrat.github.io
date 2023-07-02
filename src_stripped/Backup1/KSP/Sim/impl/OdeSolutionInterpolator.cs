// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OdeSolutionInterpolator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class OdeSolutionInterpolator
  {
    private List<RKInterpolator> _Interpolators;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInterpolator(RKInterpolator toAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAllInterpolators() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (Vector3d, Vector3d) GetRelativePositionAndVelocityAtUT(double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (Vector3d, Vector3d) GetRelativePositionAndVelocityAtUTZup(double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OdeSolutionInterpolator() => throw null;
  }
}
