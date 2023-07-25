// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClassFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class ClassFactory : Attribute
  {
    public Type classType;
    public Type dataType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassFactory(Type classType, Type dataType) => throw null;
  }
}
