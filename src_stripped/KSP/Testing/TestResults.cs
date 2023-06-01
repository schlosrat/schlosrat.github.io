// Decompiled with JetBrains decompiler
// Type: KSP.Testing.TestResults
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Testing
{
  public class TestResults
  {
    public int failed;
    public int success;
    public List<TestState> states;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestResults() => throw null;
  }
}
