// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BillboardSystem.BillboardInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.BillboardSystem
{
  public class BillboardInstance
  {
    public bool Loaded;
    public int InstanceCount;
    public Vector3 Position;
    public readonly ComputeBufferInfo ComputeBufferInfo;
    public readonly IndirectInstanceListInfo IndirectInstanceInfo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BillboardInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeBuffers() => throw null;
  }
}
