// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereHeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere Height")]
  [RequireComponent(typeof (SgtAtmosphere))]
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphereHeight")]
  public class SgtAtmosphereHeight : MonoBehaviour
  {
    public float DistanceMin;
    public float DistanceMax;
    public float HeightClose;
    public float HeightFar;
    public Camera Camera;
    [NonSerialized]
    private SgtAtmosphere cachedAtmosphere;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHeight(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtAtmosphereHeight() => throw null;
  }
}
