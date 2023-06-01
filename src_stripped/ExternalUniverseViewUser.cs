// Decompiled with JetBrains decompiler
// Type: ExternalUniverseViewUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ExternalUniverseViewUser : MonoBehaviour
{
  protected virtual string logTag
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  protected IUniverseView universeView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  protected IUniverseModel universeModel
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public bool IsConnected
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  protected IUniverseModel UniverseModel
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  protected IPhysicsSpaceProvider PhysicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  protected IScaledSpaceProvider ScaledSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void HandleLateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void HandleUniverseConnected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void HandleUniverseDisconnected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CheckUniverseConnection() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected ExternalUniverseViewUser() => throw null;
}
