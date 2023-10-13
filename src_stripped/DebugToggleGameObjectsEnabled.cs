// Decompiled with JetBrains decompiler
// Type: DebugToggleGameObjectsEnabled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugToggleGameObjectsEnabled : MonoBehaviour
{
  [SerializeField]
  [Tooltip("Keyboard key you want to use to show/hide this animated scene.")]
  private KeyCode onOffKey;
  [SerializeField]
  private GameObject[] gameObjectsToToggleInSync;
  [SerializeField]
  private GameObject[] gameObjectsToToggleOpposite;
  [SerializeField]
  private bool startState;
  private bool curState;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateToggles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugToggleGameObjectsEnabled() => throw null;
}
