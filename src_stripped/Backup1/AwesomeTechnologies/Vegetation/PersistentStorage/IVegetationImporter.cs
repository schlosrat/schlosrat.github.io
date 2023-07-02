// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.IVegetationImporter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
