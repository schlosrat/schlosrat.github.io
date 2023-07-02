// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.BoundingSphereVisibleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
