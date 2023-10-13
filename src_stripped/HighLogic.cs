// Decompiled with JetBrains decompiler
// Type: HighLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("deprecated", false)]
public class HighLogic : MonoBehaviour
{
  public bool showConsole;
  public bool showConsoleOnError;
  public string skinName;
  public GUISkin skin;
  private Vector2 scrollpos;
  private Rect windowRect;
  [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
  public static HighLogic fetch;
  public string GameSaveFolder;
  [HideInInspector]
  public SceneTransitionMatrix sceneBufferTransitionMatrix;
  public static bool FastEditorLoading;
  public static bool LoadedSceneIsEditor;
  public static bool LoadedSceneIsFlight;
  public static bool LoadedSceneHasPlanetarium;
  public static bool LoadedSceneIsGame;
  public static GameScenes LoadedScene;

  public static GUISkin Skin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static string SaveFolder
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnApplicationFocus(bool focus) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void LoadScene(GameScenes scene, bool skipMatrixLookup = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator bufferedLoad(int sceneToBeLoaded, bool loadAsync) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void setLevelFlags(GameScenes scene) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public HighLogic() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static HighLogic() => throw null;
}
