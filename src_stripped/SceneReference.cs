// Decompiled with JetBrains decompiler
// Type: SceneReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
