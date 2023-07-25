// Decompiled with JetBrains decompiler
// Type: KSP.RaiseExceptionsOnAssert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class RaiseExceptionsOnAssert
  {
    [Conditional("UNITY_ASSERTIONS")]
    [Conditional("UNITY_DEVELOPMENTBUILD")]
    [Conditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Enable(bool raiseExceptions) => throw null;
  }
}
