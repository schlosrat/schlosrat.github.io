// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCellReadbackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationCellReadbackRequest
  {
    public VegetationCellReadbackRequestType VegetationCellReadbackRequestType;
    public AsyncGPUReadbackRequest ReadbackRequest;
    public VegetationCell VegetationCell;
    public int VegetationPackageIndex;
    public int VegetationItemIndex;
    public NativeArray<int> ItemCountNativeArray;
    public NativeArray<MatrixInstance> VegetationItemMatrixInstanceNativeArray;
    public ComputeBuffer InstanceArgs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCellReadbackRequest() => throw null;
  }
}
