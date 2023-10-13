// Decompiled with JetBrains decompiler
// Type: KSP.Game.ClimbBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Game
{
  public class ClimbBehavior : SpatialBehavior
  {
    public static float TopLadderVisualPositionOffset;
    public static float BottomLadderVisualPositionOffset;
    [SerializeField]
    private List<ClimbInstance> _instances;
    private List<AsyncOperationHandle<ClimbPreset>> _loadedClimbPresetAsyncHandles;
    public Action<ClimbInstance> OnClimbStart;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbInstance FindFirstInstanceOfType(ClimbType climbType, bool includeDisabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClimbStart(ClimbInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Unregister(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Register(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadClimbPresetsAsync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseLoadedClimbPresets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ClimbInstance FindFirstInstanceOfTypeInChildren(
      Transform objectTransform,
      ClimbType climbType,
      bool includeDisabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ClimbBehavior() => throw null;
  }
}
