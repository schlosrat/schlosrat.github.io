// Decompiled with JetBrains decompiler
// Type: ScatterAudioObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class ScatterAudioObject : MonoBehaviour
{
  public int MaximumInstances;
  [NonReorderable]
  public AK.Wwise.Event[] OnActivateEvent;
  [NonReorderable]
  public AK.Wwise.Event[] OnDeactivateEvent;
  private bool _isActive;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Activate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Deactivate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsActive() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScatterAudioObject() => throw null;
}
