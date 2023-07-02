// Decompiled with JetBrains decompiler
// Type: MultiKeyDictionary`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
