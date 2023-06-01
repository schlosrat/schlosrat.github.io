// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PositionCollidersJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace KSP.Rendering.Planets
{
  [BurstCompile(CompileSynchronously = true)]
  public struct PositionCollidersJob : IJobParallelForTransform
  {
    [ReadOnly]
    public NativeList<Vector3> OffsetPositions;
    [ReadOnly]
    public Quaternion RefRotation;
    public Matrix4x4 RefToWorldMatrix;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index, TransformAccess transform) => throw null;
  }
}
