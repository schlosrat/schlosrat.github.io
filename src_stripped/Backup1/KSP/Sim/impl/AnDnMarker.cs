// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.AnDnMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
