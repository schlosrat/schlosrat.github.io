// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Extension_Methods
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  internal static class Extension_Methods
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TValue GetOrDefault<TKey, TValue>(
      this Dictionary<TKey, TValue> dictionary,
      TKey key)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TValue GetOrCreate<TKey, TValue>(
      this Dictionary<TKey, TValue> dictionary,
      TKey key,
      Func<TValue> creator)
    {
      throw null;
    }
  }
}
