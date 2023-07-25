// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ReentryGlowLightAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class ReentryGlowLightAccess : MonoBehaviour
  {
    [SerializeField]
    private List<Light> _managedLights;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightValues(float intensity, Color color, float range) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleLights(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReentryGlowLightAccess() => throw null;
  }
}
