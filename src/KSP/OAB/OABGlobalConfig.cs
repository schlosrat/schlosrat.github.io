// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABGlobalConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class OABGlobalConfig
  {
    public const string CURRENT_VERSION = "0.5";
    public string Version;
    public ObjectAssemblyBehaviorValues OABBehavioralValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OABGlobalConfig Defaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABGlobalConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABGlobalConfig(ObjectAssemblyBehaviorValues behavioralValues) => throw null;
  }
}
