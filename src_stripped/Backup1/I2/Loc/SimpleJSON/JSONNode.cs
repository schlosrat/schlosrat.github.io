// Decompiled with JetBrains decompiler
// Type: I2.Loc.SimpleJSON.JSONNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace I2.Loc.SimpleJSON
{
  public class JSONNode
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Add(string aKey, JSONNode aItem) => throw null;

    public virtual JSONNode this[int aIndex]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual JSONNode this[string aKey]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual string Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Add(JSONNode aItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JSONNode Remove(string aKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JSONNode Remove(int aIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JSONNode Remove(JSONNode aNode) => throw null;

    public virtual IEnumerable<JSONNode> Childs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<JSONNode> DeepChilds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ToString(string aPrefix) => throw null;

    public virtual int AsInt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual float AsFloat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual double AsDouble
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual bool AsBool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual JSONArray AsArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual JSONClass AsObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator JSONNode(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator string(JSONNode d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(JSONNode a, object b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(JSONNode a, object b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string Escape(string aText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode Parse(string aJSON) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Serialize(BinaryWriter aWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveToStream(Stream aData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveToCompressedStream(Stream aData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveToCompressedFile(string aFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string SaveToCompressedBase64() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveToFile(string aFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string SaveToBase64() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode Deserialize(BinaryReader aReader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromCompressedFile(string aFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromCompressedStream(Stream aData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromCompressedBase64(string aBase64) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromStream(Stream aData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromFile(string aFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JSONNode LoadFromBase64(string aBase64) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JSONNode() => throw null;
  }
}
