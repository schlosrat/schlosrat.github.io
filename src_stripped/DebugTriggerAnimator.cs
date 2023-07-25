// Decompiled with JetBrains decompiler
// Type: DebugTriggerAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugTriggerAnimator : MonoBehaviour
{
  [SerializeField]
  [Tooltip("Name of Trigger in AnimTree to start/reset the animations you want.")]
  private string animTriggerName;
  [SerializeField]
  [Tooltip("Keyboard key you want to use to trigger this animated scene.")]
  private KeyCode triggerKey;
  private Animator[] allAnimatorsInHierarchy;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugTriggerAnimator() => throw null;
}
