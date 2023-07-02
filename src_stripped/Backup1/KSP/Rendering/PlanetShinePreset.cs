// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShinePreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "PlanetShinePreset", menuName = "KSP Lighting/PlanetShinePresets", order = 100)]
  [Serializable]
  public class PlanetShinePreset : ScriptableObject
  {
    public PlanetShinePresetData presetData;

    public static PlanetShinePresetData DefaultPreset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetShinePreset() => throw null;
  }
}
