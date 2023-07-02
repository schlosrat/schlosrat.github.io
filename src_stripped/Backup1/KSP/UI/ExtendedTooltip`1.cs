// Decompiled with JetBrains decompiler
// Type: KSP.UI.ExtendedTooltip`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public abstract class ExtendedTooltip<T> : StandardTooltip
  {
    protected T _data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Configure(T data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ExtendedTooltip() => throw null;
  }
}
