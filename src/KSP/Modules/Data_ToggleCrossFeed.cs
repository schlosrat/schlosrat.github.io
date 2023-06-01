// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ToggleCrossFeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [KSPDefinition]
    [Tooltip("Whether the player can toggle crossfeed in the flight view.")]
    public bool ToggleInFlight;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ToggleCrossFeed() => throw null;
  }
}
