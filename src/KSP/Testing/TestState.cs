// Decompiled with JetBrains decompiler
// Type: KSP.Testing.TestState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Testing
{
  public class TestState
  {
    public TestInfo Info;
    public bool Succeeded;
    public string Reason;
    public string Details;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestState() => throw null;
  }
}
