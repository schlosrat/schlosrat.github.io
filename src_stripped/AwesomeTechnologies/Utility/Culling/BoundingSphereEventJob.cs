// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.BoundingSphereEventJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.Utility.Culling
{
  [BurstCompile(CompileSynchronously = true)]
  internal struct BoundingSphereEventJob : IJobParallelForFilter
  {
    [ReadOnly]
    public NativeArray<BoundingSphereInfo> BoundingSphereInfoList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(int index) => throw null;
  }
}
