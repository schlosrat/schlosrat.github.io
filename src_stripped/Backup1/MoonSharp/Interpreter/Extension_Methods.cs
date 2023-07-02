// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Extension_Methods
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
