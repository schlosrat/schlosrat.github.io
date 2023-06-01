// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DecalSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ThreeEyedGames;
using UnityEngine;

namespace KSP.Rendering
{
  public class DecalSystem : MonoBehaviour
  {
    private GameInstance Game;
    private bool previsScene;
    [SerializeField]
    private GraphicsManager GraphicsManager;
    private SessionManager SessionManager;
    [SerializeField]
    private float _decalCullingDistance;
    [SerializeField]
    private Camera _currentUnityCamera;
    [SerializeField]
    private DecaliciousRenderer _currentDecaliciousRenderer;
    [SerializeField]
    private List<Decal> _allDecals;
    [SerializeField]
    private List<Decal> _deferredDecalQueue;
    [SerializeField]
    private List<Decal> _unlitDecalQueue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPrevisSceneStart(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupDecalRenderingOnCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterDecal(Decal decal, GameObject maskObj = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddDecalToRenderer(DecaliciousRenderer renderer, Decal decal, GameObject maskObj = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDecalMask(Decal decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveDecal(Decal decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DecalSystem() => throw null;
  }
}
