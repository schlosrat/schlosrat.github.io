// Decompiled with JetBrains decompiler
// Type: IScalarModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
