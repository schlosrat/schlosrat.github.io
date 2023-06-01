// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.UniverseFlightCameraView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.impl
{
  public class UniverseFlightCameraView : UniverseCameraViewBase, ICameraRenderView
  {
    private IScaledSpaceProvider ScaledSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraRenderStack ScaledSpaceCameraStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraRenderStack PhysicsSpaceCameraStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseFlightCameraView(
      IScaledSpaceProvider scaledSpace,
      Transform scaledRoot,
      IPhysicsSpaceProvider physicsSpace,
      Transform physicsRoot,
      ICameraRenderStack scaledSpaceStack,
      ICameraRenderStack physicsSpaceStack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MatchShot(ICameraShot shot) => throw null;
  }
}
