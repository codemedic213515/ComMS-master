﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TR_積算印刷データ_QuotationPrintData
{
    public int? 見積番号_QuotationNumber { get; set; }

    public string 作成者CD_CreatorCode { get; set; }

    public int? 表示順_DisplayOrder { get; set; }

    public byte? GP番号_GPNumber { get; set; }

    public short? 工種番号_WorkTypeNumber { get; set; }

    public byte? 分類FLG_CategoryFlag { get; set; }

    public byte? 工種FLG_WorkTypeFlag { get; set; }

    public byte? 工種Child_WorkTypeChild { get; set; }

    public short? 部材FLG_MaterialFlag { get; set; }

    public string 品名及び名称_ItemNameAndDescription { get; set; }

    public string 項目_Item { get; set; }

    public string 形状寸法_Dimensions { get; set; }

    public float? 数量_Quantity { get; set; }

    public float? 補給率_ReplacementRate { get; set; }

    public float? 提出数量_SubmittedQuantity { get; set; }

    public float? NET率_NETRate { get; set; }

    public float? 社内数量_InternalQuantity { get; set; }

    public short? 単位CD_UnitCode { get; set; }

    public string 単位_Unit { get; set; }

    public short? 支給区分CD_SupplyTypeCode { get; set; }

    public string 支給区分名_SupplyTypeName { get; set; }

    public byte? 単価計算FLG_PriceCalculationFlag { get; set; }

    public decimal? 単価_Price { get; set; }

    public float? 乗率_Rate { get; set; }

    public decimal? 提出単価_SubmittedPrice { get; set; }

    public float? 原価率_CostRate { get; set; }

    public decimal? 社内単価_InternalPrice { get; set; }

    public float? 歩掛_StandardLabor { get; set; }

    public float? 雑材消耗率_MaterialConsumptionRate { get; set; }

    public decimal? 提出金額_SubmittedAmount { get; set; }

    public decimal? 社内金額_InternalAmount { get; set; }

    public short? 素材分類CD_MaterialCategoryCode { get; set; }

    public string 素材分類名_MaterialCategoryName { get; set; }
}