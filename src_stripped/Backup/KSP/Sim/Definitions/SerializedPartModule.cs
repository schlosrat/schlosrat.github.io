// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct SerializedPartModule
  {
    public string Name;
    public Type ComponentType;
    public Type BehaviourType;
    public List<SerializedModuleData> ModuleData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPartModule(PartBehaviourModule partModule, bool cloneModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPartModule(PartComponentModule partModule, bool cloneModuleData) => throw null;
  }
}
