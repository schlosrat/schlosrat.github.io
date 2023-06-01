// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IntersectMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class IntersectMarker : OrbitMarker
  {
    public IntersectMarker AssociatedIntersectMarker;

    public double RelativeDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double RelativeSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      double universalTime,
      PatchedConicsOrbit orbit,
      double relativeDistance,
      double relativeSpeed,
      bool isValid,
      IntersectMarker associatedIntersectMarker = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntersectMarker() => throw null;
  }
}
