﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComMS.Models;

public partial class TM_特記事項マスタ_TM_SpecialNoteMaster
{
    public short? 特記事項CD_SpecialNotesCode { get; set; }

    public byte? 分類CD_CategoryCode { get; set; }

    public string 分類名_CategoryName { get; set; }

    public short? 表示順_DisplayOrder { get; set; }

    public string 特記事項名_SpecialNotesName { get; set; }

    public bool? 削除FLG_DeleteFlag { get; set; }
}