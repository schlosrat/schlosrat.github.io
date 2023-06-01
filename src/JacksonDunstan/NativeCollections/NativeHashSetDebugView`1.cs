// Decompiled with JetBrains decompiler
// Type: JacksonDunstan.NativeCollections.NativeHashSetDebugView`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JacksonDunstan.NativeCollections
{
  internal sealed class NativeHashSetDebugView<T> where T : unmanaged, IEquatable<T>
  {
    private readonly NativeHashSet<T> m_Set;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeHashSetDebugView(NativeHashSet<T> set) => throw null;

    public List<T> Items
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
