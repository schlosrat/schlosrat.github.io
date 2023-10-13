// Decompiled with JetBrains decompiler
// Type: PlanetLightingToolManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "Planet Lighting Manager", menuName = "KSP Lighting/Planet Lighting", order = 120)]
[Serializable]
public class PlanetLightingToolManager : ScriptableObject
{
  public List<PlanetLightingSetup> planetLightingSetups;

  public static List<PlanetLightingSetup> defaultSetupList
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private static List<SetupData> defaultSetupData
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PlanetLightingToolManager() => throw null;
}
