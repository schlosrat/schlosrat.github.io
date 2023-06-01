// Decompiled with JetBrains decompiler
// Type: KSP.Game.KerbalAttributes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public struct KerbalAttributes
  {
    public const string DEFAULT_KERBAL_SURNAME = "Kerman";
    public const string DEFAULT_NAME_LANGUAGE = "English";
    public const string ATTRIBUTE_NAME_RAW_CUSTOM_NAME = "RAW_CUSTOM_NAME";
    public const string ATTRIBUTE_NAME_NAME = "NAME";
    public const string ATTRIBUTE_NAME_SURNAME = "SURNAME";
    public const string ATTRIBUTE_NAME_TYPE = "TYPE";
    public const string ATTRIBUTE_NAME_CONSTITUTION = "CONSTITUTION";
    public const string ATTRIBUTE_NAME_BIOGRAPHY = "BIOGRAPHY";
    public const string ATTRIBUTE_NAME_STUPIDITY = "STUPIDITY";
    public const string ATTRIBUTE_NAME_BRAVERY = "BRAVERY";
    public const string ATTRIBUTE_NAME_ISVETERAN = "ISVETERAN";
    public Dictionary<string, VarietyPreloadInfo> Attributes;
    private string _fullName;

    public string CustomNameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string FirstName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Surname
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalAttributes(string customNameKey, string firstName, string surname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalAttributes(
      SerializedKerbalAttributes serializedKerbalAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetAttribute(string attributeKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAttribute<T>(string attributeKey, object value, string attachNodeName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAttribute(string attributeKey, VarietyPreloadInfo preloadInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFullName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
