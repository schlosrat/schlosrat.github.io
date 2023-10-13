// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualizerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  public abstract class TransitionVisualizerBase : KerbalMonoBehaviour
  {
    protected SelectionState previousState;
    private SelectionState? overrideState;
    [HideInInspector]
    public Animator StateAnimator;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOverrideSelectionState(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearOverrideSelectionState(bool instant = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void HandleStateTransitionWithOverrides(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void HandleStateTransition(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void RemoveStateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RefreshVisuals(bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual string GetTriggerNameFromState(SelectionState curState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendAnimationTrigger(SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateGraphicVisual(
      SelectionState state,
      bool instant,
      Graphic target,
      TransitionVisualData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ResetGraphicVisual(Graphic target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ResetScale(Graphic target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected TransitionVisualizerBase() => throw null;
  }
}
