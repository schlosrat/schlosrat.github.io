// Decompiled with JetBrains decompiler
// Type: JacksonDunstan.NativeCollections.NativeHashSetDebugView`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
