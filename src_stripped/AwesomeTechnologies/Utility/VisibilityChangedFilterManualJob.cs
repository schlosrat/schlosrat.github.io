// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.VisibilityChangedFilterManualJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.Utility
{
  [BurstCompile]
  public struct VisibilityChangedFilterManualJob : IJob
  {
    [ReadOnly]
    public NativeList<ItemSelectorInstanceInfo> InstanceList;
    public NativeList<int> VisibilityChangedIndexList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
