// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ToggleCrossFeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [KSPDefinition]
    [Tooltip("Whether the player can toggle crossfeed in the OAB.")]
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
