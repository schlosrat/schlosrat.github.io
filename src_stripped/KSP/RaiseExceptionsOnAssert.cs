// Decompiled with JetBrains decompiler
// Type: KSP.RaiseExceptionsOnAssert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
