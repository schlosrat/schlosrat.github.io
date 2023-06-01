// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.Data_ModuleActions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
