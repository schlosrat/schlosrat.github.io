// Decompiled with JetBrains decompiler
// Type: I2.Loc.ILocalizeTargetDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
