// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OrbitMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class OrbitMarker
  {
    public double UniversalTime;
    public IPatchedOrbit Orbit;

    public bool IsValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool isValidUT(double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitMarker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitMarker(IPatchedOrbit orbit, double ut) => throw null;
  }
}
