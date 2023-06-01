// Decompiled with JetBrains decompiler
// Type: KSP.RaiseExceptionsOnAssert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class RaiseExceptionsOnAssert
  {
    [Conditional("UNITY_DEVELOPMENTBUILD")]
    [Conditional("UNITY_ASSERTIONS")]
    [Conditional("UNITY_EDITOR")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Enable(bool raiseExceptions) => throw null;
  }
}
