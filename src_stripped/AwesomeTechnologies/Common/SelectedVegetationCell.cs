// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Common.SelectedVegetationCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Common
{
  public class SelectedVegetationCell
  {
    public readonly VegetationCell VegetationCell;
    public int CameraCount;
    private readonly List<VegetationStudioCamera> _vegetationStudioCameraList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedVegetationCell(
      VegetationCell vegetationCell,
      VegetationStudioCamera vegetationStudioCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCameraReference(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCameraReference(VegetationStudioCamera vegetationStudioCamera) => throw null;
  }
}
