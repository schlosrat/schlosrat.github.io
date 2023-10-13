// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ToggleCrossFeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class Data_ToggleCrossFeed : ModuleData
  {
    [Tooltip("Whether the player can toggle crossfeed in the OAB.")]
    [KSPDefinition]
    public bool ToggleInEditor;
    [Tooltip("Whether the player can toggle crossfeed in the flight view.")]
    [KSPDefinition]
    public bool ToggleInFlight;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ToggleCrossFeed() => throw null;
  }
}
