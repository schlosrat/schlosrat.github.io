// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.TestListContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Iteration.UI
{
  public class TestListContainer : ApiDataContext
  {
    [DataList("elements")]
    private ContextListProperty<TestElement> Elements
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestListContainer() => throw null;

    [DataAction("insert")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InsertElement(int index = -1, string name = null) => throw null;

    [DataAction("remove")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveElement(int index = -1) => throw null;

    [DataAction("clear")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [DataAction("shuffle")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shuffle() => throw null;

    [DataAction("move")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(int from, int to) => throw null;

    [DataAction("DEBUG_test1")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugTest1() => throw null;
  }
}
