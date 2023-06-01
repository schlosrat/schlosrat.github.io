// Decompiled with JetBrains decompiler
// Type: I2.Loc.SimpleJSON.JSONClass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace I2.Loc.SimpleJSON
{
  public class JSONClass : JSONNode, IEnumerable
  {
    private Dictionary<string, JSONNode> m_Dict;

    public override JSONNode this[string aKey]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override JSONNode this[int aIndex]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Add(string aKey, JSONNode aItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JSONNode Remove(string aKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JSONNode Remove(int aIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override JSONNode Remove(JSONNode aNode) => throw null;

    public override IEnumerable<JSONNode> Childs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString(string aPrefix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Serialize(BinaryWriter aWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JSONClass() => throw null;
  }
}
