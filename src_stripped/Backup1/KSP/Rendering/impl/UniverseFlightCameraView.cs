// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.UniverseFlightCameraView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
