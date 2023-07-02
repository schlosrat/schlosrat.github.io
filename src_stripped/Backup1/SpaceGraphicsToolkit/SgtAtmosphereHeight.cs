// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereHeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphereHeight")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere Height")]
  [RequireComponent(typeof (SgtAtmosphere))]
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
