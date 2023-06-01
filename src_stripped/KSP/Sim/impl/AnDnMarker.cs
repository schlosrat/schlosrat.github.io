// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.AnDnMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class AnDnMarker : OrbitMarker
  {
    public double Inclination;
    public AnDnMarker AssociatedTargetMarker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      double universalTime,
      PatchedConicsOrbit orbit,
      double inclination,
      bool isValid,
      AnDnMarker associatedTargetMarker = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnDnMarker() => throw null;
  }
}
