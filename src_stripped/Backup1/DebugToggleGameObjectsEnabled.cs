// Decompiled with JetBrains decompiler
// Type: DebugToggleGameObjectsEnabled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugToggleGameObjectsEnabled : MonoBehaviour
{
  [Tooltip("Keyboard key you want to use to show/hide this animated scene.")]
  [SerializeField]
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
