// Decompiled with JetBrains decompiler
// Type: BootstrapSceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class BootstrapSceneLoader : MonoBehaviour
{
  [SerializeField]
  [Tooltip("The name of the initial scene to load")]
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
