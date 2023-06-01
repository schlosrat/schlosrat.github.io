// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamBookmarks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  [Serializable]
  public class PQSFreeCamBookmarks
  {
    private const int BOOKMARK_COUNT = 10;
    [SerializeField]
    private PQSFreeCamState[] _bookmarks;
    [SerializeField]
    private bool[] _isSet;
    [SerializeField]
    private string[] _descriptions;
    private static readonly KeyCode[] bookmarkKeys;

    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PQSFreeCamState this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDescription(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDescription(int index, string description) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyCode GetMappedKey(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDisplayKey(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCamBookmarks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQSFreeCamBookmarks() => throw null;
  }
}
