// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.IndirectInstanceListInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;

namespace AwesomeTechnologies.VegetationSystem
{
  public class IndirectInstanceListInfo
  {
    public NativeList<ScatterInstance> InstancedIndirectInstanceList;
    public bool Created;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndirectInstanceListInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
