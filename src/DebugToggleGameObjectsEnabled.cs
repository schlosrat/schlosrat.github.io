// Decompiled with JetBrains decompiler
// Type: DebugToggleGameObjectsEnabled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
