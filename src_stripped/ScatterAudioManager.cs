// Decompiled with JetBrains decompiler
// Type: ScatterAudioManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScatterAudioManager
{
  private static ScatterAudioManager _instance;
  private Dictionary<string, List<ScatterAudioObject>> _scatterObjects;
  private Dictionary<string, List<ScatterAudioManager.ScatterAudioRuntime>> _scatterRuntimeObjects;
  private static int MAX_SCATTER;
  private static bool _warningLogged;
  private const string NAME_SUFFIX_CLONE = "(Clone)";

  public static ScatterAudioManager Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetInstance(ScatterAudioManager instance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DeleteInstance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Cleanup() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static int CompareScatterDistance(ScatterAudioObject x, ScatterAudioObject y) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string GetSanitizedName(string objectName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterScatterObject(ScatterAudioObject obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnregisterScatterObject(ScatterAudioObject obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScatterAudioManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ScatterAudioManager() => throw null;

  private class ScatterAudioRuntime
  {
    public GameObject AudioObject;
    public ScatterAudioObject ScatterObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScatterAudioRuntime(GameObject audioObject, ScatterAudioObject scatterObject) => throw null;
  }
}
