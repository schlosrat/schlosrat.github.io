// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.Bootstrap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class Bootstrap : IDisposable
  {
    public const Bootstrap.OnCreateCallbackDelegate DEFAULT_ON_CREATE_CALLBACK = null;
    public const Bootstrap.OnDestroyCallbackDelegate DEFAULT_ON_DESTROY_CALLBACK = null;
    private Bootstrap.OnCreateCallbackDelegate _onCreateCallback;
    private Bootstrap.OnDestroyCallbackDelegate _onDestroyCallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bootstrap Create(
      Bootstrap.OnCreateCallbackDelegate onCreateCallback,
      Bootstrap.OnDestroyCallbackDelegate onDestroyCallback)
    {
      throw null;
    }

    public Bootstrap.OnCreateCallbackDelegate OnCreateCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnCreateCallback(
      Bootstrap.OnCreateCallbackDelegate onCreateCallback)
    {
      throw null;
    }

    public Bootstrap.OnDestroyCallbackDelegate OnDestroyCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnDestroyCallback(
      Bootstrap.OnDestroyCallbackDelegate onDestroyCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bootstrap(
      Bootstrap.OnCreateCallbackDelegate onCreateCallback,
      Bootstrap.OnDestroyCallbackDelegate onDestroyCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~Bootstrap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      Bootstrap.OnCreateCallbackDelegate onCreateCallback,
      Bootstrap.OnDestroyCallbackDelegate onDestroyCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Dispose(bool disposing) => throw null;

    public delegate void OnCreateCallbackDelegate();

    public delegate void OnDestroyCallbackDelegate();
  }
}
