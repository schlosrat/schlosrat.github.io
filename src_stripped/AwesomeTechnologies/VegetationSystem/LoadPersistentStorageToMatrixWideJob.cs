// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.LoadPersistentStorageToMatrixWideJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation.PersistentStorage;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct LoadPersistentStorageToMatrixWideJob : IJobParallelFor
  {
    [DeallocateOnJobCompletion]
    [ReadOnly]
    public NativeArray<PersistentVegetationItem> InstanceList;
    public NativeArray<MatrixInstance> VegetationInstanceMatrixList;
    public Vector3 VegetationSystemPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
