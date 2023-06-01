// Decompiled with JetBrains decompiler
// Type: BootstrapSceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
