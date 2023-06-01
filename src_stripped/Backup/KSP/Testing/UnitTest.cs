// Decompiled with JetBrains decompiler
// Type: KSP.Testing.UnitTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Testing
{
  public abstract class UnitTest
  {
    public List<TestState> Results;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnitTest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TestStartUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TestTearDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void assertEquals(string testname, object value, object shouldbe) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal IEnumerable<TestState> PerformTest() => throw null;
  }
}
