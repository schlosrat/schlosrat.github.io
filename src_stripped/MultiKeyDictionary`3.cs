// Decompiled with JetBrains decompiler
// Type: MultiKeyDictionary`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MultiKeyDictionary<T1, T2, T3> : Dictionary<T1, Dictionary<T2, T3>>
{
  public new Dictionary<T2, T3> this[T1 key]
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool ContainsKey(T1 key1, T2 key2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MultiKeyDictionary() => throw null;
}
