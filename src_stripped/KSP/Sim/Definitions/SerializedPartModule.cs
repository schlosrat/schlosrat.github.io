// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
