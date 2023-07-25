// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.BoundingSphereVisibleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.Utility.Culling
{
  [BurstCompile(CompileSynchronously = true)]
  internal struct BoundingSphereVisibleJob : IJobParallelForFilter
  {
    [ReadOnly]
    public NativeArray<BoundingSphereInfo> BoundingSphereInfoList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(int index) => throw null;
  }
}
