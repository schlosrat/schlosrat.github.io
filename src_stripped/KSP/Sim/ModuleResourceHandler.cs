// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResourceHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class ModuleResourceHandler
  {
    private TimeWarp timeWarp;
    public List<ModuleResource> inputResources;
    public List<ModuleResource> outputResources;
    public bool moduleResourceBasedPrimaryIsInput;
    public IPartModule partModule;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAwake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAverageInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleResourceHandler() => throw null;
  }
}
