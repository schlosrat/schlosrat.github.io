// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.RaycastCommandListPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
