﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TM_消費税_TM_ConsumptionTax
{
    public short? 税CD_TaxCode { get; set; }

    public short? 表示順_DisplayOrder { get; set; }

    public string 税名_TaxName { get; set; }

    public float? 税率_TaxRate { get; set; }

    public DateTime? 開始期間_StartPeriod { get; set; }

    public DateTime? 終了期間_EndPeriod { get; set; }

    public bool? 削除FLG_DeleteFlag { get; set; }
}