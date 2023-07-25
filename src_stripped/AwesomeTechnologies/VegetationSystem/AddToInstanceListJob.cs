// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.AddToInstanceListJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile]
  public struct AddToInstanceListJob : IJob
  {
    [DeallocateOnJobCompletion]
    public NativeArray<VegetationInstance> SourceInstanceArray;
    public NativeList<VegetationInstance> TargetInstanceList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
