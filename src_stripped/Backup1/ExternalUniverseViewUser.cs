// Decompiled with JetBrains decompiler
// Type: ExternalUniverseViewUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
