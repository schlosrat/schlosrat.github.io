// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationPackageInstances
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationPackageInstances
  {
    public readonly List<NativeList<MatrixInstance>> VegetationItemMatrixList;
    public readonly List<NativeList<VSPInstanceData>> VegetationItemVSPInstanceDataList;
    public readonly List<ComputeBufferInfo> VegetationItemComputeBufferList;
    public JobHandle LoadVegetationJobHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationPackageInstances(int vegetationItemCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInstanceMemory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
