// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.ActionGroupStates
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
