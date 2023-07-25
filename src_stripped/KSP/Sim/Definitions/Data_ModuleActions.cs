// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.Data_ModuleActions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public class Data_ModuleActions : ModuleData
  {
    [KSPState]
    public Dictionary<string, uint> customActionMappings;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateActionMapping(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemoveActionMapping(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemoveActionMapping(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal KSPActionGroup GetStoredActionGroup(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ModuleActions() => throw null;
  }
}
