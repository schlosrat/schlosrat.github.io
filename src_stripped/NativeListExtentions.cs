// Decompiled with JetBrains decompiler
// Type: NativeListExtentions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;

public static class NativeListExtentions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ClearMemory<T>(this NativeList<T> nativeList) where T : unmanaged => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CompactMemory<T>(this NativeList<T> nativeList) where T : unmanaged => throw null;
}
