// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioInitializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  public class KSPAudioInitializer : AkInitializer, IKSPAudioInitializer
  {
    public GameObject EventManagerPrefab;
    public GameObject AudioListenerPrefab;
    private List<GameObject> _lateUpdateObjects;
    public static Action OnAllBanksLoaded;
    private bool _allBanksLoaded;
    private AkBank[] _banksToLoad;
    private KSPPartAmbientEmitter[] _cameraEmitters;
    private bool _wwiseInitialized;
    public bool EnableLateUpdateObjects;
    private Vector3d _floatingOriginSnapDeltaThisFrame;
    private bool _snapPositionOffsetMessageRegistered;
    private bool _wasAppFocused;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool WwiseInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnApplicationFocusChanged(bool focus) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterForLateAudioUpdates(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRegisterForLateAudioUpdates(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterForLateAudioUpdates(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFrameSnapPositions(Vector3d physicStepVector, List<Action> actionList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetWwisePositionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateScatterAudioManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteScatterAudioManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioInitializer() => throw null;
  }
}
