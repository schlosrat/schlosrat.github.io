// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_StatusLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
  public sealed class Data_StatusLight : ModuleData
  {
    [KSPDefinition]
    public string LightObjectTransformName;
    [KSPDefinition]
    public string LightMeshMaterialTransformName;
    [KSPDefinition]
    public string LightMaterialPropertyName;
    [ColorUsage(true, true)]
    [KSPDefinition]
    public Color ColorOn;
    [KSPDefinition]
    [ColorUsage(true, true)]
    public Color ColorOff;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_StatusLight() => throw null;
  }
}
