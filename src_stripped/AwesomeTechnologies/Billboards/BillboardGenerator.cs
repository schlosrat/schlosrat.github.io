// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Billboards.BillboardGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.BillboardSystem;
using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Billboards
{
  public class BillboardGenerator
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh CreateMeshFromBillboardInstance(BillboardInstance billboardInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BillboardGenerator() => throw null;

    [BurstCompile(CompileSynchronously = true)]
    public struct CreateBillboardMeshJob : IJob
    {
      [ReadOnly]
      public NativeList<MatrixInstance> InstanceList;
      public NativeList<Vector3> VerticeList;
      public NativeList<int> IndexList;
      public NativeList<Vector2> UvList;
      public NativeList<Vector4> Uv2List;
      public NativeList<Vector2> Uv3List;
      public NativeList<Vector3> NormalList;
      public float BoundsYExtent;
      public float VegetationItemSize;
      private Vector3 _srcVert0;
      private Vector3 _srcVert1;
      private Vector3 _srcVert2;
      private Vector3 _srcVert3;
      private Vector2 _srcUVs0;
      private Vector2 _srcUVs1;
      private Vector2 _srcUVs2;
      private Vector2 _srcUVs3;
      private int _srcIndex0;
      private int _srcIndex1;
      private int _srcIndex2;
      private int _srcIndex3;
      private int _srcIndex4;
      private int _srcIndex5;
      public Vector3 CellPolarPosition;
      public float PolaSphereRadius;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3 PolarToCartesian(Vector2 polar, float radius) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SetupData() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector3 ExtractTranslationFromMatrix(Matrix4x4 matrix) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Vector3 ExtractScaleFromMatrix(Matrix4x4 matrix) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Quaternion ExtractRotationFromMatrix(Matrix4x4 matrix) => throw null;
    }
  }
}
