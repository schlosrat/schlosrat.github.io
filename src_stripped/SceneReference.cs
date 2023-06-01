// Decompiled with JetBrains decompiler
// Type: SceneReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SceneReference : ISerializationCallbackReceiver
{
  [SerializeField]
  private string scenePath;

  public int BuildIndex
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string ScenePath
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static implicit operator string(SceneReference sceneReference) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeforeSerialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnAfterDeserialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SceneReference() => throw null;
}
