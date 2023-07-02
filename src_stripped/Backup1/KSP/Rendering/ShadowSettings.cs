// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ShadowSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "shadow_settings", menuName = "KSP/Settings/Shadow Settings")]
  public class ShadowSettings : ScriptableObject
  {
    public ShadowConfig VABShadowConfigHigh;
    public ShadowConfig VABShadowConfigMed;
    public ShadowConfig VABShadowConfigLow;
    public ShadowConfig SurfaceShadowConfigHigh;
    public ShadowConfig SurfaceShadowConfigMed;
    public ShadowConfig SurfaceShadowConfigLow;
    public ShadowConfig OrbitShadowConfigHigh;
    public ShadowConfig OrbitShadowConfigMed;
    public ShadowConfig OrbitShadowConfigLow;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowConfig GetVABShadowConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowConfig GetSurfaceShadowConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowConfig GetOrbitShadowConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowSettings() => throw null;
  }
}
