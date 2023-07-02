// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ContextActionTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class ContextActionTest : MonoBehaviour
  {
    public ContextBindRoot bindRoot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IDataContextReadonly GetTestContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextActionTest() => throw null;

    public class TestObject
    {
      private IProperty<int> s_maxHealth;
      [DataProperty("health")]
      public PropertyReadonly<int> m_health;
      private int lastHealth;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TestObject(IProperty<int> maxHealth) => throw null;

      [DataAction("kill")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Kill() => throw null;

      [DataAction("revive")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Revive() => throw null;

      [DataAction("heal")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Heal() => throw null;

      [DataAction("hurt")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Hurt() => throw null;

      [DataAction("setHealth")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetHealth(int health) => throw null;

      [DataAction("debugPrint")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DebugPrint() => throw null;
    }
  }
}
