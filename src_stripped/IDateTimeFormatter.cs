// Decompiled with JetBrains decompiler
// Type: IDateTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

public interface IDateTimeFormatter
{
  string PrintTimeLong(double time);

  string PrintTimeStamp(double time, bool days = false, bool years = false);

  string PrintTimeStampCompact(double time, bool days = false, bool years = false);

  string PrintTime(double time, int valuesOfInterest, bool explicitPositive);

  string PrintTimeCompact(double time, bool explicitPositive);

  string PrintDateDelta(double time, bool includeTime, bool includeSeconds, bool useAbs);

  string PrintDateDeltaCompact(double time, bool includeTime, bool includeSeconds, bool useAbs);

  string PrintDate(double time, bool includeTime, bool includeSeconds = false);

  string PrintDateNew(double time, bool includeTime);

  string PrintDateCompact(double time, bool includeTime, bool includeSeconds = false);

  int Minute { get; }

  int Hour { get; }

  int Day { get; }

  int Year { get; }
}
