// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.ObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class ObjectPool<T> where T : new()
  {
    private readonly List<T> _available;
    private readonly List<T> _inUse;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Get() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanUp(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectPool() => throw null;
  }
}
