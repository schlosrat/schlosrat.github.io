// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.RaycastHitListPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class RaycastHitListPool
  {
    private readonly List<NativeList<RaycastHit>> _available;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeList<RaycastHit> Get() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Return(NativeList<RaycastHit> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanUp(NativeList<RaycastHit> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RaycastHitListPool() => throw null;
  }
}
