﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TI_素材乗率データMaterialLoadRatioData
{
    public string 作成者CD_CreatorCode { get; set; }

    public int? 見積番号_EstimationNumber { get; set; }

    public short? 素材分類CD_MaterialCategoryCode { get; set; }

    public byte? ABC材_ABCMaterial { get; set; }

    public short? 表示順_DisplayOrder { get; set; }

    public string 素材分類名_MaterialCategoryName { get; set; }

    public float? 乗率標準設定_StandardLoadRatioSetting { get; set; }

    public float? 乗率設定_LoadRatioSetting { get; set; }

    public float? 原価率標準設定_StandardCostRateSetting { get; set; }

    public float? 原価率設定_CostRateSetting { get; set; }

    public string 表示素材分類名_DisplayMaterialCategoryName { get; set; }
}