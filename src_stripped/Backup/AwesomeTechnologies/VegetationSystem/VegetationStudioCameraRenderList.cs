// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationStudioCameraRenderList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationStudioCameraRenderList
  {
    [NonSerialized]
    public readonly List<NativeList<MatrixInstance>> VegetationItemMergeMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> BillboardVegetationItemMergeMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD0MatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD1MatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD2MatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD3MatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD0ShadowMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD1ShadowMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD2ShadowMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Matrix4x4>> VegetationItemLOD3ShadowMatrixList;
    [NonSerialized]
    public readonly List<NativeList<Vector4>> VegetationItemLOD0LodFadeList;
    [NonSerialized]
    public readonly List<NativeList<Vector4>> VegetationItemLOD1LodFadeList;
    [NonSerialized]
    public readonly List<NativeList<Vector4>> VegetationItemLOD2LodFadeList;
    [NonSerialized]
    public readonly List<NativeList<Vector4>> VegetationItemLOD3LodFadeList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCameraRenderList(int vegetationItemCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeMatrixList(List<NativeList<Matrix4x4>> list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeMatrixInstanceList(List<NativeList<MatrixInstance>> list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeVector4List(List<NativeList<Vector4>> list) => throw null;
  }
}
