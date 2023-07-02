// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCellReadbackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public NativeArray<ScatterInstance> ScatterInstanceNativeArray;
    public ComputeBuffer InstanceArgs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCellReadbackRequest() => throw null;
  }
}
