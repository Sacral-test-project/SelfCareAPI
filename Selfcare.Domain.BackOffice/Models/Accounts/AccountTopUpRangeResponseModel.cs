﻿// Decompiled with JetBrains decompiler
// Type: Selfcare.Domain.BackOffice.Models.Accounts.AccountTopUpRangeResponseModel
// Assembly: Selfcare.Domain.BackOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 925D2EFC-2F9C-4686-933B-32D249405106
// Assembly location: C:\Users\vgunturu\Downloads\OneDrive_1_9-7-2024\Selfcare.Domain.BackOffice.dll

using System;

#nullable disable
namespace Selfcare.Domain.BackOffice.Models.Accounts
{
  public class AccountTopUpRangeResponseModel
  {
    public int AccountId { get; set; }

    public Decimal MinimumReplenishmentAmount { get; set; }

    public Decimal MaximumReplenishmentAmount { get; set; }
  }
}
