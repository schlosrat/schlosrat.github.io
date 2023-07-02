// Decompiled with JetBrains decompiler
// Type: KSP.Api.ListPropertyChangedArgs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Api
{
  public struct ListPropertyChangedArgs
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ListPropertyChangedArgs(
      ListPropertyChangeType ListChangeType,
      int OldIndex = -1,
      int NewIndex = -1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ListPropertyChangedArgs Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ListPropertyChangedArgs ItemInserted(int newIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ListPropertyChangedArgs ItemDeleted(int oldIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ListPropertyChangedArgs ItemMoved(int oldIndex, int newIndex) => throw null;

    public ListPropertyChangeType ListChangeType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int OldIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int NewIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }
  }
}
