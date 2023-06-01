// Decompiled with JetBrains decompiler
// Type: KSP.Map.GalaxyCubeRenderShim
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Rendering;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class GalaxyCubeRenderShim : MonoBehaviour, ICameraRenderView
  {
    private Transform galaxyCube;
    private ICoordinateSystem galaxyCoordinates;
    public Camera GalaxyCubeCamera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(Transform galaxyCube, ICoordinateSystem galaxyCoordinates) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD ComputeRotationFromOtherForGalaxyCube(
      ICoordinateSystem galaxyCoordinates,
      ITransformFrame other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD GetCameraRotation(ICoordinateSystem galaxyCoordinates, Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MatchShot(ICameraShot shot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraRenderStack GetCameraRenderStack(RenderSpaceType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterCameraRenderStack(
      RenderSpaceType type,
      ICameraRenderStack stack,
      int order)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ClearCameraRenderStack(RenderSpaceType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GalaxyCubeRenderShim() => throw null;
  }
}
