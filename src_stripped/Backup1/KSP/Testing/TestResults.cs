// Decompiled with JetBrains decompiler
// Type: KSP.Testing.TestResults
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
