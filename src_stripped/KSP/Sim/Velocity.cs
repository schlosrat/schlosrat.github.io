// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Velocity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
