// Decompiled with JetBrains decompiler
// Type: DragRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DragRenderer
{
  private Material _dragCubeMaterial;
  private Camera _aeroCamera;
  private GameObject _aeroCameraObject;
  private int _cameraLayerInt;
  private RenderTexture _renderTexture;
  private Texture2D _aeroTexture;
  private Renderer[] renderers;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DragRenderer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator RenderAndCalculateDragCubes(
    GameObject loadedPart,
    GameObject sourcePart,
    List<DragCube> outputDragCubes,
    bool outputTextures,
    bool doSynchronously)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator RenderPartDragCubes(
    GameObject prefab,
    List<DragCube> dragCubes,
    DragRenderContext dragCubeContext,
    bool outputTextures = false,
    bool doSynchronously = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator RenderDragCubes(
    GameObject partObject,
    IMultipleDragCube multipleInterface,
    DragRenderContext dragCubeContext,
    bool isPlaying,
    bool outputTextures = false,
    bool doSynchronously = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator SetMultipleDragCubePosition(
    DragRenderContext renderContext,
    IMultipleDragCube multipleInterface,
    string positionName,
    bool isPlaying)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Bounds CalculatePartBounds(GameObject part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetAeroCamera(
    DragCube.DragFace direction,
    Bounds partBounds,
    DragRenderContext dragCubeContext)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void RenderAeroTexture(
    Camera camera,
    Renderer[] renderers,
    RenderTexture renderTexture,
    Texture2D outputTexture)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CalculateAerodynamics(
    out float area,
    out float drag,
    out float depth,
    Texture2D aeroTexture,
    Camera aeroCamera)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateTextures() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateCamera(GameObject targetPart) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReleaseTextures(bool isPlaying) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupPartForRender(DragRenderContext dragCubeContext, bool isPlaying) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CleanPartMonoBehaviors(GameObject partObject, bool isPlaying) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CleanPartEffects(GameObject partObject, bool isPlaying) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CleanPartRenderers(GameObject partObject, bool isPlaying) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupPartMaterials(GameObject targetPart, int renderLayer) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void WriteTexture(
    Texture2D aeroTexture,
    string partObjectName,
    string positionName,
    string faceName,
    bool isPlaying)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetPlanarSize(DragCube.DragFace direction, Bounds partBounds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetPlanarDepth(DragCube.DragFace direction, Bounds partBounds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 GetPlanarDirection(DragCube.DragFace direction) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 GetPlanarCenter(DragCube.DragFace direction, Bounds partBounds) => throw null;
}
