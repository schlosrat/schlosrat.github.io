// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.IVegetationImporter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  public interface IVegetationImporter
  {
    string ImporterName { get; }

    PersistentVegetationStoragePackage PersistentVegetationStoragePackage { get; set; }

    VegetationPackagePro VegetationPackagePro { get; set; }

    PersistentVegetationStorage PersistentVegetationStorage { get; set; }

    void OnGUI();
  }
}
