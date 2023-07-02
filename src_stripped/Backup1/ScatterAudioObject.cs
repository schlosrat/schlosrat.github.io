// Decompiled with JetBrains decompiler
// Type: ScatterAudioObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
