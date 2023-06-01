// Decompiled with JetBrains decompiler
// Type: Debug_FloatNaNs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class Debug_FloatNaNs : MonoBehaviour
{
  [DllImport("msvcrt.dll")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint _control87(uint a, uint b) => throw null;

  [DllImport("msvcrt.dll")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint _clearfp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Debug_FloatNaNs() => throw null;
}
