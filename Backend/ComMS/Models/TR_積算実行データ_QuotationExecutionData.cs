﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TR_積算実行データ_QuotationExecutionData
{
    public int? 見積番号_QuotationNumber { get; set; }

    public string 作成者CD_CreatorCode { get; set; }

    public int? 表示順_DisplayOrder { get; set; }

    public byte? GP番号1_GPNumber1 { get; set; }

    public byte? GP番号2_GPNumber2 { get; set; }

    public short? 素材分類CD_MaterialCategoryCode { get; set; }

    public string 素材分類名_MaterialCategoryName { get; set; }

    public decimal? 提出金額_SubmittedAmount { get; set; }

    public float? 提出工数_SubmittedWorkHours { get; set; }

    public decimal? 社内金額_InHouseAmount { get; set; }

    public float? 社内工数_InHouseWorkHours { get; set; }

    public decimal? 提出総計_SubmittedTotal { get; set; }

    public decimal? 社内総計_InHouseTotal { get; set; }
}