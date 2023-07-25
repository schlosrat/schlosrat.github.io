// Decompiled with JetBrains decompiler
// Type: InputBinding_obsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
