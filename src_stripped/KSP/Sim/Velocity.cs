// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Velocity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [DebuggerDisplay("{_Value_ForDebuggerOnly}")]
  public struct Velocity
  {
    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Velocity(IMotion relativeToMotion, Vector3d relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Velocity(IMotion relativeToMotion, Vector relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Velocity Reframed(
      Velocity velocity,
      IMotion newRelativeToMotion,
      Position observerPosition)
    {
      throw null;
    }
  }
}
