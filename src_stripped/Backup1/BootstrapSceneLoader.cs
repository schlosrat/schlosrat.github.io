// Decompiled with JetBrains decompiler
// Type: BootstrapSceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class BootstrapSceneLoader : MonoBehaviour
{
  [Tooltip("The name of the initial scene to load")]
  [SerializeField]
  private string _initialSceneName;
  public static string CommandLineArgs;
  private static bool s_isInitialized;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BootstrapSceneLoader() => throw null;
}
