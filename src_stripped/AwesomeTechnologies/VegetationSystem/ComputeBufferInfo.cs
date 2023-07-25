// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.ComputeBufferInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
