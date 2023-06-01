// Decompiled with JetBrains decompiler
// Type: InputBinding_obsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

[Obsolete("requires some porting", false)]
public class InputBinding_obsolete : ICloneable
{
  public InputBindingModes switchState;
  public static bool linRotState;
  public bool useSwitchState;
  public ulong inputLockMask;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsLocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsUnlocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual bool IsNeutral() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public object Clone() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public InputBinding_obsolete() => throw null;
}
