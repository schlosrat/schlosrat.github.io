// Decompiled with JetBrains decompiler
// Type: InputBinding_obsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
