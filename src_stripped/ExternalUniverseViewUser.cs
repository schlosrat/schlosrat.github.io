// Decompiled with JetBrains decompiler
// Type: ExternalUniverseViewUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
