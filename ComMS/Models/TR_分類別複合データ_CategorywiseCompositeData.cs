﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TR_分類別複合データ_CategorywiseCompositeData
{
    public int? 表示順_DisplayOrder { get; set; }

    public int? ＧP番号_GPNumber { get; set; }

    public string 頁番号_PageNumber { get; set; }

    public string 番号_Number { get; set; }

    public short? 素材分類CD_MaterialCategoryCode { get; set; }

    public string 素材分類名_MaterialCategoryName { get; set; }

    public string 品名及び名称_ItemNameAndDescription { get; set; }

    public string 形状寸法_Dimensions { get; set; }

    public string 単位_Unit { get; set; }

    public float? 数量_Quantity { get; set; }

    public decimal? 複合単価_CompositeUnitPrice { get; set; }

    public decimal? 複合金額_CompositeAmount { get; set; }

    public decimal? 単価A_UnitPriceA { get; set; }

    public decimal? 単価B_UnitPriceB { get; set; }

    public float? 補給率_FillRate { get; set; }

    public float? 付属率_AccessoryRate { get; set; }

    public float? 雑材率_MiscellaneousRate { get; set; }

    public float? 歩掛1_ManHourRate1 { get; set; }

    public float? 歩掛2_ManHourRate2 { get; set; }

    public float? その他_Other { get; set; }

    public decimal? 社内単価_InHouseUnitPrice { get; set; }

    public decimal? 社内金額_InHouseAmount { get; set; }

    public string 支給区分名_SupplyCategoryName { get; set; }
}