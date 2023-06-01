// Decompiled with JetBrains decompiler
// Type: I2.Loc.ILocalizeTargetDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public abstract class ILocalizeTargetDescriptor
  {
    public string Name;
    public int Priority;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool CanLocalize(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract ILocalizeTarget CreateTarget(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type GetTargetType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ILocalizeTargetDescriptor() => throw null;
  }
}
