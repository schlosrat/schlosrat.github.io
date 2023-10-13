// Decompiled with JetBrains decompiler
// Type: ScatterAudioObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScatterAudioObject : MonoBehaviour
{
  public int MaximumInstances;
  [NonReorderable]
  public Event[] OnActivateEvent;
  [NonReorderable]
  public Event[] OnDeactivateEvent;
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
