// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.ReferenceEqualityComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class ReferenceEqualityComparer : IEqualityComparer<object>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IEqualityComparer<object>.Equals(object x, object y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IEqualityComparer<object>.GetHashCode(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReferenceEqualityComparer() => throw null;
  }
}
