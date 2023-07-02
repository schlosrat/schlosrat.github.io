// Decompiled with JetBrains decompiler
// Type: KSP.Map.GalaxyCubeRenderShim
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
