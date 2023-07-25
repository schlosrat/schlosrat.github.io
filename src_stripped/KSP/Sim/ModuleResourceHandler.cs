﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ModuleResourceHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
