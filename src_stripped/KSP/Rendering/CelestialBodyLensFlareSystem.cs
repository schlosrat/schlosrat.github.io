// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLensFlareSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CelestialBodyLensFlareSystem : MonoBehaviour
  {
    private GameInstance Game;
    private bool previsScene;
    [SerializeField]
    private LightingSystem LightingSystem;
    private GraphicsManager GraphicsManager;
    private SessionManager SessionManager;
    [SerializeField]
    private ProFlareBatch proFlareBatch;

    public Camera FlareCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPrevisSceneStart(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLensFlareSystem() => throw null;
  }
}
