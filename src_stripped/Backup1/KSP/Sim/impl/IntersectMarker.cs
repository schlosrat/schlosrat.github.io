// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IntersectMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
