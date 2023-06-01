// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.ActionGroupStates
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct ActionGroupStates
  {
    public Dictionary<KSPActionGroup, bool> states;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupStates(KSPActionGroup group, bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupStates(
      IEnumerable<KeyValuePair<KSPActionGroup, bool>> states)
    {
      throw null;
    }
  }
}
