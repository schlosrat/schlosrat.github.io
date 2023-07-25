// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.ReferenceEqualityComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
