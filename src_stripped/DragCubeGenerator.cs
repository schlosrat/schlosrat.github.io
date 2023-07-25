// Decompiled with JetBrains decompiler
// Type: DragCubeGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class DragCubeGenerator : KerbalMonoBehaviour
{
  public static string DRAG_CUBE_TAG;
  private static float _aeroCameraSize;
  private static readonly int _mainTex;
  private static readonly int _bumpMap;
  private Dictionary<GameObject, DragCubeGenerator.DragCubeRequest> requestsDictionary;
  [FormerlySerializedAs("dragCubeMaterial")]
  [SerializeField]
  private Material _dragCubeMaterial;
  [SerializeField]
  [Header("Debug Tools")]
  [FormerlySerializedAs("debugOutputTextures")]
  private bool _outputTextures;
  [SerializeField]
  private string _outputTexturesPath;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDebugTools(bool enableOutput) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GenerateDragCube(GameObject objPart, ref DragCube dragCube) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator GenerateDragCubeCoroutine(
    GameObject objPart,
    DragCube dragCube,
    DragCubeGenerator.DragCubeContext dragCubeContext,
    bool doSynchronously = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateAeroCamera(DragCubeGenerator.DragCubeContext dragCubeContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateAeroTextures(DragCubeGenerator.DragCubeContext dragCubeContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReleaseTextures(DragCubeGenerator.DragCubeContext dragCubeContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetupPartForRender(DragCubeGenerator.DragCubeContext dragCubeContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool SetMainTexture(Material mat) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator RenderDragCubes(
    GameObject partObject,
    IMultipleDragCube multipleInterface,
    DragCubeGenerator.DragCubeContext dragCubeContext,
    bool doSynchronously = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Bounds CalculatePartBounds(GameObject part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetAeroCamera(
    DragCube.DragFace direction,
    Bounds partBounds,
    DragCubeGenerator.DragCubeContext dragCubeContext)
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

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SynchronousRenderProceduralDragCube(
    GameObject objPart,
    IMultipleDragCube multipleInterface,
    ref DragCube dragCube)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator RenderProceduralDragCube(DragCubeGenerator.DragCubeRequest request) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DragCubeGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DragCubeGenerator() => throw null;

  private struct DragCubeRequest
  {
    public GameObject objPart;
    public IMultipleDragCube multipleInterface;
    public DragCube dragCube;
    public Action<DragCube> onComplete;
    public bool doSynchronously;
  }

  public class DragCubeContext
  {
    public Camera AeroCamera;
    public GameObject AeroCameraGameObject;
    public Texture2D AeroTexture;
    public int CameraLayerInt;
    public RenderTexture RenderTexture;
    public DragCube TargetDragCube;
    public GameObject TargetPart;
    public Renderer[] renderers;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DragCubeContext() => throw null;
  }
}
