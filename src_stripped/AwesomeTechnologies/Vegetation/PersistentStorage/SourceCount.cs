// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.SourceCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public class SourceCount
  {
    public int VegetationSourceID;
    public int Count;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceCount() => throw null;
  }
}
