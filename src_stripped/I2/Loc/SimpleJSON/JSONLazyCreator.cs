// Decompiled with JetBrains decompiler
// Type: I2.Loc.SimpleJSON.JSONLazyCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace I2.Loc.SimpleJSON
{
  internal class JSONLazyCreator : JSONNode
  {
    private JSONNode m_Node;
    private string m_Key;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JSONLazyCreator(JSONNode aNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JSONLazyCreator(JSONNode aNode, string aKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Set(JSONNode aVal) => throw null;

    public override JSONNode this[int aIndex]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override JSONNode this[string aKey]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Add(JSONNode aItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Add(string aKey, JSONNode aItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(JSONLazyCreator a, object b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(JSONLazyCreator a, object b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString(string aPrefix) => throw null;

    public override int AsInt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override float AsFloat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override double AsDouble
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override bool AsBool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override JSONArray AsArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override JSONClass AsObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
