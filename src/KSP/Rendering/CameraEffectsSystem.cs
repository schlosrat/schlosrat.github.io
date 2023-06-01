// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CameraEffectsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CameraEffectsSystem : KerbalMonoBehaviour
  {
    public Dictionary<string, List<GameObject>> weatherParticleFieldObjs;
    public Dictionary<string, List<GameObject>> ringParticleFieldObjs;
    private Camera _camera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamera(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddWeatherField(string bodyName, GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRingField(string bodyName, GameObject obj, CelestialBodyRing ring) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryRemoveFields(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraEffectsSystem() => throw null;
  }
}
