// Decompiled with JetBrains decompiler
// Type: JacksonDunstan.NativeCollections.NativeHashSetDebugView`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
