﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TW_同一CD異単価チェック_SameCDDifferentUnitPriceCheck
{
    public int? 部材No_MaterialNumber { get; set; }

    public short? 工種番号_WorkTypeNumber { get; set; }

    public short? 部材番号_MaterialNumber { get; set; }

    public short? 分類1_Category1 { get; set; }

    public short? 分類2_Category2 { get; set; }

    public short? 分類3_Category3 { get; set; }

    public short? 分類4_Category4 { get; set; }

    public string 工種名_WorkTypeName { get; set; }

    public string 部材名_MaterialName { get; set; }

    public float? 乗率_RateOfIncrease { get; set; }

    public float? 原価率_CostRate { get; set; }

    public decimal? 標準単価_StandardUnitPrice { get; set; }

    public decimal? 提出単価_SubmittedUnitPrice { get; set; }

    public decimal? 社内単価_InternalUnitPrice { get; set; }

    public bool? 適用FLG_ApplicationFlag { get; set; }
}