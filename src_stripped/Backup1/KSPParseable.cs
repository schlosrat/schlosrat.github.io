// Decompiled with JetBrains decompiler
// Type: KSPParseable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public struct KSPParseable
{
  public string value;
  public ParseableType type;

  public int ValueInt
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float ValueFloat
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double ValueDouble
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool ValueBool
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector2 ValueV2
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 ValueV3
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector4 ValueV4
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Quaternion ValueQuat
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPParseable(object Value, ParseableType Type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPParseable(string Value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string Save() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsValueValid() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override string ToString() => throw null;
}
