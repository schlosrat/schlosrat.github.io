// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.NativeListExtentions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;

namespace AwesomeTechnologies.Utility
{
  public static class NativeListExtentions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearMemory<T>(this NativeList<T> nativeList) where T : unmanaged => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CompactMemory<T>(this NativeList<T> nativeList) where T : unmanaged => throw null;
  }
}
