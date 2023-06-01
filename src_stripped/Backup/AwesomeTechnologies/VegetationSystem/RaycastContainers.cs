// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.RaycastContainers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class RaycastContainers
  {
    public NativeArray<RaycastHit> RaycastHits;
    public NativeArray<RaycastCommand> RaycastCommands;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RaycastContainers() => throw null;
  }
}
