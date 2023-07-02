// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizeTarget`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  public abstract class LocalizeTarget<T> : ILocalizeTarget where T : Object
  {
    public T mTarget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsValid(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected LocalizeTarget() => throw null;
  }
}
