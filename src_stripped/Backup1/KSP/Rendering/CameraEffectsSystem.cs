// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CameraEffectsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
