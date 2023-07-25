// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyChecklist
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyChecklist : IObjectBuilderChecklist
  {
    private ObjectAssemblyBuilderEvents events;
    public List<IObjectAssemblyDesignConcern> designConcerns;

    public List<IObjectAssemblyDesignConcern> DesignConcerns
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyChecklist(ObjectAssemblyBuilderEvents eventSystemToUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckAssemblyForDesignConcerns() => throw null;
  }
}
