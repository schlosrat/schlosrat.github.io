// Decompiled with JetBrains decompiler
// Type: KSP.AssemblyUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
