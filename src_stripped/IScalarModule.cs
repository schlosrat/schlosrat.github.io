// Decompiled with JetBrains decompiler
// Type: IScalarModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

public interface IScalarModule
{
  string ScalarModuleID { get; }

  float GetScalar { get; }

  bool CanMove { get; }

  void SetScalar(float t);

  void SetUIRead(bool state);

  void SetUIWrite(bool state);

  bool IsMoving();

  EventDataObsolete<float, float> OnMoving { get; }

  EventDataObsolete<float> OnStop { get; }
}
