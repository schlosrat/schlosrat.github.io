// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSTargetProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQSTargetProvider
  {
    private Transform _pqsTransform;
    private ITransformFrame _pqsBodyFrame;
    private IUniverseObserver _observerRef;
    private Camera _renderCamera;

    public Camera RenderCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSTargetProvider(Transform pqsTransform, Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSTargetProvider(
      Transform pqsTransform,
      Camera cam,
      ITransformFrame pqsBodyFrame,
      IUniverseObserver observerRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraRight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeTargetPosition(float offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeObserverPosition() => throw null;
  }
}
