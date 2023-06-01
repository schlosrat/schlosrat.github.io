// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIDependendsOn`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.UI.Flight
{
  public abstract class UIDependendsOn<T> : UIElement
  {
    protected abstract T Dependency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InjectDependency(T dependency) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void SetBackendCallbacks(T backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void ClearBackendCallbacks(T backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDependendsOn() => throw null;
  }
}
