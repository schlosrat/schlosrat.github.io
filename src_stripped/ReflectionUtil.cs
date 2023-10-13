// Decompiled with JetBrains decompiler
// Type: ReflectionUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

public static class ReflectionUtil
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<ReflectionUtil.AttributedType<Tatt>> GetAttributedTypesInAssemblies<Tbase, Tatt>(
    List<Assembly> assemblies)
    where Tbase : class
    where Tatt : Attribute
  {
    throw null;
  }

  public class AttributedType<Tatt>
  {
    public System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Tatt Attribute
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttributedType(System.Type t, Tatt attrib) => throw null;
  }
}
