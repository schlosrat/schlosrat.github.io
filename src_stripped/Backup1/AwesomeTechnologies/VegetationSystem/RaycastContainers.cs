// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.RaycastContainers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
