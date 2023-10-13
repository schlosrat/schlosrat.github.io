// Decompiled with JetBrains decompiler
// Type: KSP.Game.PrevisGameInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Messages;
using KSP.Rendering;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class PrevisGameInstance : MonoBehaviour, IUpdateDriver, ILateUpdateDriver
  {
    public GameState gameState;
    public GraphicsManager GraphicsManager;
    public VFXPlanetaryContextTestTool planetTestTool;
    private SessionManager _sessionManager;
    public PrevisCameraManager PrevisCameraManager;
    private bool shutdownInProgress;
    private const string VFXContextualTestingPrefabPath = "Assets/Iteration/VFX/ContextualVFXSystem/VFXPlanetaryContextTestTool.prefab";
    private static GameObject contextTestingPrefab;
    private const int DEFAULT_UPDATE_PRIORITY = 0;
    private bool _isUpdateListDirty;
    private readonly List<IUpdate> _pendingUpdateAdds;
    private readonly List<IUpdate> _updateList;
    private readonly PrevisGameInstance.UpdateComparer _updateComparer;
    private const int DEFAULT_LATEUPDATE_PRIORITY = -1;
    private bool _isLateUpdateListDirty;
    private readonly List<ILateUpdate> _pendingLateUpdateAdds;
    private readonly List<ILateUpdate> _lateUpdateList;
    private readonly PrevisGameInstance.LateUpdateComparer _lateUpdateComparer;

    public static PrevisGameInstance Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MessageCenter Messages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AssetProvider Assets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PersistentProfileManager ProfileManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameStateMachine GlobalGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CelestialBodyProvider CelestialBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PrevisCelestialBodyProvider PrevisCelestialBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SessionManager SessionManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PhysicsSettingsManager PhysicsSettingsManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ShutdownInProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeDependencies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnApplicationQuit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePrefabs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterUpdate(IUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterUpdate(IUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterLateUpdate(ILateUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterLateUpdate(ILateUpdate item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetupVFXContextSystemTesting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DisableVFXContextSystemTesting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrevisGameInstance() => throw null;

    private class UpdateComparer : PrevisGameInstance.NullComparer<IUpdate>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override int CompareTo(IUpdate x, IUpdate y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public UpdateComparer() => throw null;
    }

    private class LateUpdateComparer : PrevisGameInstance.NullComparer<ILateUpdate>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override int CompareTo(ILateUpdate x, ILateUpdate y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LateUpdateComparer() => throw null;
    }

    private class NullComparer<T> : IComparer<T>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(T x, T y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected virtual int CompareTo(T x, T y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NullComparer() => throw null;
    }
  }
}
