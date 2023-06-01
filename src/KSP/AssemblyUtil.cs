// Decompiled with JetBrains decompiler
// Type: KSP.AssemblyUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class AssemblyUtil
  {
    public static Assembly executingAssembly;
    public static List<Type> allTypes;
    public static List<Type> kspTypes;
    private static Dictionary<Type, List<TypeDataCache>> attributeCache;
    private static Dictionary<string, Type> nameToType;
    private static HashSet<string> warned;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AssemblyUtil() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Type GetKspType(string typeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TypeDataCache> GetKspTypesWithAttributes<T>() where T : Attribute => throw null;
  }
}
