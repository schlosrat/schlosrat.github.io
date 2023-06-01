// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.ComputeBufferInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class ComputeBufferInfo
  {
    public ComputeBuffer InstanceBuffer;
    public ComputeBuffer ArgsBuffer;
    public const int ScratchSlotIndex = 0;
    public const int InstanceCountIndex = 1;
    public const int XYZThreadGroupCountStartIndex = 2;
    public const int ArgsBufferSize = 5;
    public bool Spawned;
    public bool Created;
    public int InstanceCount;
    public bool InstanceBufferHasBeenCompacted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBufferInfo() => throw null;
  }
}
