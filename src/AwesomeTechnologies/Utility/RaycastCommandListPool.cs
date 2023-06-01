// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.RaycastCommandListPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class RaycastCommandListPool
  {
    private readonly List<NativeList<RaycastCommand>> _available;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeList<RaycastCommand> Get() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Return(NativeList<RaycastCommand> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanUp(NativeList<RaycastCommand> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RaycastCommandListPool() => throw null;
  }
}
