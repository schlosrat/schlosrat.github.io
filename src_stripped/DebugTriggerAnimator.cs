// Decompiled with JetBrains decompiler
// Type: DebugTriggerAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugTriggerAnimator : MonoBehaviour
{
  [SerializeField]
  [Tooltip("Name of Trigger in AnimTree to start/reset the animations you want.")]
  private string animTriggerName;
  [Tooltip("Keyboard key you want to use to trigger this animated scene.")]
  [SerializeField]
  private KeyCode triggerKey;
  private Animator[] allAnimatorsInHierarchy;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugTriggerAnimator() => throw null;
}
