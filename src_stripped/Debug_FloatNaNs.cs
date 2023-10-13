// Decompiled with JetBrains decompiler
// Type: Debug_FloatNaNs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
