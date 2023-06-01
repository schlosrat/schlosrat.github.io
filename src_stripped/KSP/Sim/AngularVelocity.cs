// Decompiled with JetBrains decompiler
// Type: KSP.Sim.AngularVelocity
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
  public struct AngularVelocity
  {
    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AngularVelocity(IMotion relativeToMotion, Vector3d localAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AngularVelocity(IMotion relativeToMotion, Vector relativeAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reframe(IMotion newRelativeMotion) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AngularVelocity Reframed(
      AngularVelocity angularVelocity,
      IMotion newReferenceMotion)
    {
      throw null;
    }
  }
}
