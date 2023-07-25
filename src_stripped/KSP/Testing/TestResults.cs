// Decompiled with JetBrains decompiler
// Type: KSP.Testing.TestResults
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
