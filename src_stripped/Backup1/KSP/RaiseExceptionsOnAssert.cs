// Decompiled with JetBrains decompiler
// Type: KSP.RaiseExceptionsOnAssert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class RaiseExceptionsOnAssert
  {
    [Conditional("UNITY_EDITOR")]
    [Conditional("UNITY_ASSERTIONS")]
    [Conditional("UNITY_DEVELOPMENTBUILD")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Enable(bool raiseExceptions) => throw null;
  }
}
