﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.ExportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public class ExportData
  {
    public List<PersistentVegetationCell> PersistentVegetationCellList;
    public List<PersistentVegetationInstanceInfo> PersistentVegetationInstanceInfoList;
    public List<byte> PersistentVegetationInstanceSourceList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExportData() => throw null;
  }
}
