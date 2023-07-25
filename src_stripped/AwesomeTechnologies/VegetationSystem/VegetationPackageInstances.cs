// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationPackageInstances
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationPackageInstances
  {
    public readonly List<NativeList<ScatterInstance>> VegetationItemInstanceList;
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
