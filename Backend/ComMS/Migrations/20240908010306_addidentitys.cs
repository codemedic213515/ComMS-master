using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComMS.Migrations
{
    /// <inheritdoc />
    public partial class addidentitys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    UserCD = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    部署CD_DepartmentCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserWinID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    請求番号_InvoiceNumber = table.Column<int>(type: "int", nullable: true),
                    権限_Permissions = table.Column<byte>(type: "tinyint", nullable: true),
                    有効無効_EnabledDisabled = table.Column<bool>(type: "bit", nullable: true),
                    労務単価_LaborUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Initial = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.UserCD);
                });
            #region To Comment
            /***
            migrationBuilder.CreateTable(
                name: "T_ErrorList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ProcedureName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Err_Number = table.Column<int>(type: "int", nullable: true),
                    Err_Source = table.Column<string>(type: "ntext", nullable: true),
                    Err_Description = table.Column<string>(type: "ntext", nullable: true),
                    Err_Date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "T_TablePath",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: true),
                    DbName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OldTableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewTableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FLG = table.Column<byte>(type: "tinyint", nullable: true),
                    Use = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TC_ZIP",
                columns: table => new
                {
                    ZIP = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    TodoufukenCD = table.Column<byte>(type: "tinyint", nullable: true),
                    Todoufuken = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ShikuCD = table.Column<short>(type: "smallint", nullable: true),
                    Shiku = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CyousonCD = table.Column<short>(type: "smallint", nullable: true),
                    Cyouson = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TC_データテーブル一覧",
                columns: table => new
                {
                    No = table.Column<byte>(type: "tinyint", nullable: true),
                    Class = table.Column<byte>(type: "tinyint", nullable: true),
                    テーブル名 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TC_見積情報",
                columns: table => new
                {
                    UserCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TC_部署データ",
                columns: table => new
                {
                    部署CD_DepartmentCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    部署名_DepartmentName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_基礎データ_BasicData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示見積番号_ShowQuotationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    日付_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    工事名称1_ConstructionProjectName1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称2_ProjectName2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    市町村CD_CityCode = table.Column<int>(type: "int", nullable: true),
                    工事場所_ConstructionProjectSite = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先CD_SubmissionDestinationCode = table.Column<int>(type: "int", nullable: true),
                    提出先1_SubmissionAddress1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_SubmissionAddress2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    発注者CD_ClientCode = table.Column<int>(type: "int", nullable: true),
                    発注者_Client = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    仕入先_Vendor = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ランクCD_LevelCode = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費FLG_SiteMiscellaneousExpensesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    現場雑費率_SiteMiscellaneousExpenseRate = table.Column<float>(type: "real", nullable: true),
                    現場雑費端数_SiteMiscellaneousExpenseRounding = table.Column<byte>(type: "tinyint", nullable: true),
                    諸経費FLG_MiscellaneousExpensesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    諸経費率_MiscellaneousExpenseRate = table.Column<float>(type: "real", nullable: true),
                    諸経費_MiscellaneousExpenses = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費端数_MiscellaneousExpenseRounding = table.Column<byte>(type: "tinyint", nullable: true),
                    電線管NET率_ElectricalConduitNETRate = table.Column<float>(type: "real", nullable: true),
                    電線管補給率_ConduitSupplyRate = table.Column<float>(type: "real", nullable: true),
                    電線類NET率_WireNETRate = table.Column<float>(type: "real", nullable: true),
                    電線類補給率_WireSupplyRate = table.Column<float>(type: "real", nullable: true),
                    電線計算単位_WireCalculationRate = table.Column<byte>(type: "tinyint", nullable: true),
                    単価計算基準_UnitPriceCalculationStandard = table.Column<byte>(type: "tinyint", nullable: true),
                    歩掛計算基準_LaborCostCalculationStandard = table.Column<byte>(type: "tinyint", nullable: true),
                    雑材消耗FLG_MiscellaneousMaterialConsumptionFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    労務費基準_LaborCostStandard = table.Column<float>(type: "real", nullable: true),
                    雑材A材B材_MiscellaneousMaterialsAandB = table.Column<byte>(type: "tinyint", nullable: true),
                    労務費FLG_LaborCostFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    労務費計算FLG_LaborCostCalculationFlag = table.Column<bool>(type: "bit", nullable: true),
                    付帯工事FLG_associatedconstructionwork = table.Column<byte>(type: "tinyint", nullable: true),
                    ケーブルFLG_CableFlag = table.Column<int>(type: "int", nullable: true),
                    ケーブル係数FLG_CableCoefficientFlag = table.Column<int>(type: "int", nullable: true),
                    ケーブル係数_CableCoefficient = table.Column<float>(type: "real", nullable: true),
                    Cラック付属品FLG_CRackAccessoriesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    Cラック付属品係数_CRackAccessoriesCoefficient = table.Column<float>(type: "real", nullable: true),
                    Cラック支持材FLG_CRackSupportMaterialFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    Cラック支持材係数_CRackSupportMaterialCoefficient = table.Column<float>(type: "real", nullable: true),
                    RW付属品FLG_RWAccessoriesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    RW付属品係数_RWAccessoriesCoefficient = table.Column<float>(type: "real", nullable: true),
                    RW支持材FLG_RWSupportMaterialFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    RW支持材係数_RWSupportMaterialCoefficient = table.Column<float>(type: "real", nullable: true),
                    照明取付FLG_LightingInstallationFlag = table.Column<int>(type: "int", nullable: true),
                    照明取付係数FLG_LightingInstallationCoefficientFlag = table.Column<int>(type: "int", nullable: true),
                    照明取付係数_LightingInstallationCoefficient = table.Column<float>(type: "real", nullable: true),
                    盤取付FLG_PanelInstallationFlag = table.Column<int>(type: "int", nullable: true),
                    盤取付係数FLG_PanelInstallationCoefficientFlag = table.Column<int>(type: "int", nullable: true),
                    盤取付係数_PanelInstallationCoefficient = table.Column<float>(type: "real", nullable: true),
                    配管係数FLG_PipingCoefficientFlag = table.Column<int>(type: "int", nullable: true),
                    配管係数1_PipingCoefficient1 = table.Column<float>(type: "real", nullable: true),
                    配管係数2_PipingCoefficient2 = table.Column<float>(type: "real", nullable: true),
                    付帯工事乗率_AncillaryConstructionRate = table.Column<float>(type: "real", nullable: true),
                    付帯工事原価率_AncillaryConstructionCostRate = table.Column<float>(type: "real", nullable: true),
                    共通費乗率_CommonExpenseRatio = table.Column<float>(type: "real", nullable: true),
                    共通費原価率_CommonCostRate = table.Column<float>(type: "real", nullable: true),
                    乗率分類番号_RateCategoryNumber = table.Column<int>(type: "int", nullable: true),
                    積算複合FLG_AccumulationCompositFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種部材変更FLG_S_WorkTypeMaterialChangeFlag_S = table.Column<bool>(type: "bit", nullable: true),
                    工種部材変更FLG_F_WorkTypeMaterialChangeFlag_F = table.Column<bool>(type: "bit", nullable: true),
                    電工労務単価A_ElectricianlaborunitpriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電工労務単価B_ELectricianlaborunitpriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作労務単価A_GenerallaborunitpriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作労務単価B_GenerallaborunitpriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    見積金額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    採用案No_AdoptedPlanNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    作成日付_CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    更新日付_DateUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    用途_Use = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    建物構造_BuildingStructure = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    塔屋_TowerBuilding = table.Column<byte>(type: "tinyint", nullable: true),
                    地上_AboveGround = table.Column<byte>(type: "tinyint", nullable: true),
                    地下_UnderGround = table.Column<byte>(type: "tinyint", nullable: true),
                    戸数_NumberOfUnits = table.Column<byte>(type: "tinyint", nullable: true),
                    延床面積_TotalFloorArea = table.Column<float>(type: "real", nullable: true),
                    基準床面積_ReferenceFloorArea = table.Column<float>(type: "real", nullable: true),
                    EPS合計面積_ExpandedPolystyreneTotalArea = table.Column<float>(type: "real", nullable: true),
                    備考_Remarks = table.Column<string>(type: "string", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_基礎データ_BasicData", x => x.見積番号_QuotationNumber);
                });

            migrationBuilder.CreateTable(
                name: "TI_工種データ_ConstructionTypeData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplaySequence = table.Column<int>(type: "int", nullable: true),
                    表示工種番号_DiplayWorkTypeNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    工種FLG_Work_ConstructionTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_ConstructionTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    工種CD_ConstructionTypeCode = table.Column<int>(type: "int", nullable: true),
                    工種名_ConstructionTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗FLG_MiscellaneousMaterialConsumptionFlag = table.Column<bool>(name: "[雑材消耗FLG_MiscellaneousMaterialConsumptionFlag", type: "bit", nullable: true),
                    CL付属FLG_CLAccessoryFlag = table.Column<bool>(type: "bit", nullable: true),
                    CL支持FLG_CLSupportFlag = table.Column<bool>(type: "bit", nullable: true),
                    RW付属FLG_RWAccessoryFlag = table.Column<bool>(type: "bit", nullable: true),
                    RW支持FLG_RWSupportFlag = table.Column<bool>(type: "bit", nullable: true),
                    C補足材FLG_CAdditionalMaterialFlag = table.Column<bool>(type: "bit", nullable: true),
                    照明FLG_LightingFlag = table.Column<bool>(type: "bit", nullable: true),
                    盤FLG_PanelFlag = table.Column<bool>(type: "bit", nullable: true),
                    戸数_NumberOfUnits = table.Column<byte>(type: "tinyint", nullable: true),
                    提出金額_AmountSubmitted = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    機材費A_EquipmentCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    機材費B_EquipmentCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材消耗品費A_MiscellaneousMaterialsExpenseA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材消耗品費B_MiscellaneousMaterialsExpenseB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費A_LaborCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費B_LaborCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事A_AssociatedConstructionA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事B_AssociatedConstructionB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費A_SharedExpensesA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費B_SharedExpensesB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費A_OnSiteMiscellaneousCostsA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費B_OnSiteMiscellaneousCostsB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費A_GeneralExpensesA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費B_GeneralExpensesB = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_比較GP名データ_ComparisonGroupNameData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    GPCD_GPCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplaySequence = table.Column<short>(type: "smallint", nullable: true),
                    GP名_GPName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    選択FLG_ChoiceFlag = table.Column<bool>(type: "bit", nullable: true),
                    仕入先CD1_VendorCode1 = table.Column<short>(type: "smallint", nullable: true),
                    仕入先CD2_VendorCode2 = table.Column<short>(type: "smallint", nullable: true),
                    仕入先CD3_VendorCode3 = table.Column<short>(type: "smallint", nullable: true),
                    採用仕入先CD_ApprovedVendorCode = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_比較データ_ComparisonData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Group番号_GroupNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplaySequence = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    単価1_UnitPrice1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価2_UnitPrice2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価3_UnitPrice3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_IncreaseRate = table.Column<float>(type: "real", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_ProposedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InHouseUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出金額_ProposedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    選択FLG_ChoiceFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_比較基本データ_ComparisonBasicData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    製作所名1_ManufacturerName1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    製作所名2_ManufacturerName2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    製作所名3_ManufacturerName3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    採用製作所名_ApprovedManufacturerName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    掛率_MarkUpRate = table.Column<byte>(type: "tinyint", nullable: true),
                    金額_AmountOfdecimal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    頁_Page = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_積算表紙データ_EstimatedGeneralData",
                columns: table => new
                {
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    表示見積番号_VisibleQuotationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    暦FLG_CalenderFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    日付_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    提出先CD_SubmissionDestinationCode = table.Column<int>(type: "int", nullable: true),
                    提出先1_SubmissionDestination1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_SubmissionDestination2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    敬称FLG_HonorificTitleFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    敬称_HonorificTitle = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    見積金額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    見積総額_TotalQuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    工事名称_ProjectName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    工事名称1_ProjectName1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称2_ProjectName2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    市町村CD_CityCode = table.Column<short>(type: "smallint", nullable: true),
                    工事場所_ProjectSite = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    発注者CD_ClientCode = table.Column<int>(type: "int", nullable: true),
                    発注者_Client = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工期_ProjectDuration = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    有効期間_validityperiodOrDuration = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    支払条件FLG_PaymentTermsFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    支払条件_PaymentTerms = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    特記事項1_SpecialNote1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項2_SpecialNote2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項3_SpecialNote3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項4_SpecialNote4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項5_SpecialNote5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    消費税FLG_SalesTaxFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    消費税率_SalesTaxRate = table.Column<float>(type: "real", nullable: true),
                    消費税_SalesTax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    消費税額_SalesTaxAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    御社ネットFLG_CompanyNetworkFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    御社ネット金額_CompanyNetworkAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    御社ネット_CompanyNetwork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    諸経費FLG_MiscellaneousExpensesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    諸経費率_MiscellaneousExpensesRate = table.Column<float>(type: "real", nullable: true),
                    諸経費_MiscellaneousExpenses = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    出精値引FLG_DiscountFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    出精値引_SpecialDiscount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金抜きFLG_PriceExclusionFlag = table.Column<bool>(type: "bit", nullable: true),
                    特別項目_SpecialItem = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特別金額_SpecialAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    内訳ヘッター_BreakdownHeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    フッターFLG_FooterFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    内訳フッター_BreakdownFooter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    経費FLG1_ExpensesFlag1 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名1_ExpensesName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費1_Expense1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG2_ExpenseFlag2 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名2_ExpenseName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費2_Expense2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG3_ExpenseFlag3 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名3ExpensesName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費3_Expense3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG4_ExpensesFlag4 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名4_ExpensesName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費4_Expenses4 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線まとめFLG_CableSummaryFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_積算集計データ_EstimatedAggregationData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    案_Proposal = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplaySequence = table.Column<int>(type: "int", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_ConstructionTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_ConstructionTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量 = table.Column<float>(type: "real", nullable: true),
                    補給率 = table.Column<float>(type: "real", nullable: true),
                    提出数量 = table.Column<float>(type: "real", nullable: true),
                    NET率 = table.Column<float>(type: "real", nullable: true),
                    社内数量 = table.Column<float>(type: "real", nullable: true),
                    付属品率 = table.Column<float>(type: "real", nullable: true),
                    単位CD = table.Column<short>(type: "smallint", nullable: true),
                    単位 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価計算FLG = table.Column<byte>(type: "tinyint", nullable: true),
                    単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率 = table.Column<float>(type: "real", nullable: true),
                    提出単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率 = table.Column<float>(type: "real", nullable: true),
                    社内単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛 = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率 = table.Column<float>(type: "real", nullable: true),
                    塗装係数 = table.Column<float>(type: "real", nullable: true),
                    天井開口係数 = table.Column<float>(type: "real", nullable: true),
                    提出金額 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材 = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_積算集計ヘッダ_EstimatedAggregationHeader",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    案_Plan = table.Column<byte>(type: "tinyint", nullable: true),
                    労務単価A_LaborCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務単価B_LaborCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費FLG_ConstructionExpenseFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    現場雑費率_ConstructionExpenseRate = table.Column<float>(type: "real", nullable: true),
                    現場雑費端数_ConstructionExpenseFraction = table.Column<int>(type: "int", nullable: true),
                    諸経費FLG_MiscellaneousExpenseFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    諸経費率_MiscellaneousExpenseRate = table.Column<float>(type: "real", nullable: true),
                    諸経費端数_MiscellaneousExpenseFraction = table.Column<int>(type: "int", nullable: true),
                    雑材消耗FLG_MaterialConsumptionFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    雑材A材B材_MaterialAAndB = table.Column<byte>(type: "tinyint", nullable: true),
                    労務費基準_LaborCostStandard = table.Column<float>(type: "real", nullable: true),
                    労務費FLG_LaborCostFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    労務費計算FLG_LaborCostCalculationFlag = table.Column<bool>(type: "bit", nullable: true),
                    付帯工事FLG_AdditionalWorkFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_素材その他データMaterialAndAdditionalData",
                columns: table => new
                {
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    その他率設定_OtherRateSetting = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_素材乗率データMaterialLoadRatioData",
                columns: table => new
                {
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_EstimationNumber = table.Column<int>(type: "int", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    乗率標準設定_StandardLoadRatioSetting = table.Column<float>(type: "real", nullable: true),
                    乗率設定_LoadRatioSetting = table.Column<float>(type: "real", nullable: true),
                    原価率標準設定_StandardCostRateSetting = table.Column<float>(type: "real", nullable: true),
                    原価率設定_CostRateSetting = table.Column<float>(type: "real", nullable: true),
                    表示素材分類名_DisplayMaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_複合表紙データ_CompositCoverData",
                columns: table => new
                {
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_EstimationNumber = table.Column<int>(type: "int", nullable: true),
                    表示見積番号_DisplayedEstimationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    暦FLG_CalendarFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    日付_Date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    提出先CD_SubmissionDestinationCode = table.Column<int>(type: "int", nullable: true),
                    提出先1_SubmissionDestination1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_SubmissionDestination2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    敬称FLG_HonorificFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    敬称_Honorific = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    見積金額_EstimatedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    見積総額_TotalEstimatedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    工事名称_ProjectName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    工事名称1_ProjectName1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称2_ProjectName2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    市町村CD_CityTownVillageCode = table.Column<short>(type: "smallint", nullable: true),
                    工事場所_ProjectLocation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    発注者CD_OrdererCode = table.Column<int>(type: "int", nullable: true),
                    発注者_Orderer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工期_ConstructionPeriod = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    有効期間_ValidityPeriod = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    支払条件FLG_PaymentConditionFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    支払条件_PaymentCondition = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    特記事項1_SpecialNotes1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項2_SpecialNotes2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項3_SpecialNotes3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項4_SpecialNotes4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特記事項5_SpecialNotes5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    消費税FLG_ConsumptionTaxFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    消費税率_ConsumptionTaxRate = table.Column<float>(type: "real", nullable: true),
                    消費税_ConsumptionTax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    消費税額_ConsumptionTaxAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    御社ネットFLG_YourCompanyNetFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    御社ネット金額_YourCompanyNetAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    御社ネット_YourCompanyNet = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    諸経費FLG_MiscellaneousExpensesFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    諸経費率_MiscellaneousExpensesRate = table.Column<float>(type: "real", nullable: true),
                    諸経費_MiscellaneousExpenses = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    出精値引FLG_SpecialDiscountFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    出精値引_SpecialDiscount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金抜きFLG_PricingExclusionFlag = table.Column<bool>(type: "bit", nullable: true),
                    特別項目_SpecialItem = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    特別金額_SpecialAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    内訳ヘッター_BreakdownHeader = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    フッターFLG_FooterFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    内訳フッター_BreakdownFooter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    経費FLG1_ExpensesFlag1 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名1_ExpensesName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費1_Expenses1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG2_ExpensesFlag2 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名2_ExpensesName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費2_Expenses2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG3_ExpensesFlag3 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名3_ExpensesName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費3_Expenses3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費FLG4_ExpensesFlag4 = table.Column<byte>(type: "tinyint", nullable: true),
                    経費名4_ExpensesName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    経費4_Expenses4 = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_複合集計データ_CompositAggregationData",
                columns: table => new
                {
                    見積番号 = table.Column<int>(type: "int", nullable: true),
                    作成者CD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号 = table.Column<int>(type: "int", nullable: true),
                    部材番号 = table.Column<short>(type: "smallint", nullable: true),
                    案 = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順 = table.Column<int>(type: "int", nullable: true),
                    分類FLG = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量 = table.Column<float>(type: "real", nullable: true),
                    単位CD = table.Column<short>(type: "smallint", nullable: true),
                    単位 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    補給率 = table.Column<float>(type: "real", nullable: true),
                    付属品率 = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率 = table.Column<float>(type: "real", nullable: true),
                    その他 = table.Column<float>(type: "real", nullable: true),
                    単価計算FLG = table.Column<byte>(type: "tinyint", nullable: true),
                    単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率 = table.Column<float>(type: "real", nullable: true),
                    原価率 = table.Column<float>(type: "real", nullable: true),
                    提出単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A = table.Column<float>(type: "real", nullable: true),
                    歩掛B = table.Column<float>(type: "real", nullable: true),
                    電工単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    比較表FLG = table.Column<bool>(type: "bit", nullable: true),
                    塗装係数 = table.Column<float>(type: "real", nullable: true),
                    天井開口係数 = table.Column<float>(type: "real", nullable: true),
                    提出金額 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材 = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_複合集計ヘッダ_CompositeAggregationHeader",
                columns: table => new
                {
                    見積番号_EstimationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    案_Plan = table.Column<byte>(type: "tinyint", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作単価A_NormalOperationUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作単価B_NormalOperationUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通仮設費FLG_CommonTemporaryConstructionCostsFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    共通仮設費A_CommonTemporaryConstructionCostsA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通仮設費B_CommonTemporaryConstructionCostsB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場管理費FLG_SiteManagementCostsFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    現場管理費A_SiteManagementCostsA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場管理費B_SiteManagementCostsB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    一般管理費FLG_GeneralAdministrativeCostsFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    一般管理費A_GeneralAdministrativeCostsA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    一般管理費B_GeneralAdministrativeCostsB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    新営改修FLG_NewConstructionOrRenovationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    付帯工事FLG_AdditionalWorkFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_部材データ_MaterialsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材FLG_MaterialFlag = table.Column<int>(type: "int", nullable: true),
                    分類1_Category1 = table.Column<int>(type: "int", nullable: true),
                    分類2_Category2 = table.Column<int>(type: "int", nullable: true),
                    分類3_Category3 = table.Column<int>(type: "int", nullable: true),
                    分類4_Classification4 = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材明細_MaterialDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    形状寸法_ShapeAndSize = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    部材GRP_MaterialGroup = table.Column<byte>(type: "tinyint", nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<int>(type: "int", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<int>(type: "int", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    塗装費_PaintingCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    天井開口_CeilingOpening = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoriesRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialsRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_LaborA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_LaborB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<int>(type: "int", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterials = table.Column<byte>(type: "tinyint", nullable: true),
                    日付追加_DateAdded = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    最終更新日_LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TI_部材データ_MaterialsData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TI_配線器具個数データ_WiringDeviceQuantityData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    配線器具種別_WiringDeviceType = table.Column<byte>(type: "tinyint", nullable: true),
                    配線分類CD_WiringClassificationCode = table.Column<short>(type: "smallint", nullable: true),
                    配線分類名称_WiringClassificationName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    数量_Quantity = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TI_配線器具単価データ_WiringDeviceUintPriceData",
                columns: table => new
                {
                    見積番号_EstimationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    提出単価_部品_SubmissionPrice_Parts = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_α_SubmissionPrice_Alpha = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_取付枠_SubmissionPrice_MountingFrame = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_プレート_SubmissionPrice_Plate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_部品_InternalPrice_Parts = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_α_InternalPrice_Alpha = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_取付枠_InternalPrice_MountingFrame = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_プレート_InternalPrice_Plate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    販売定価_部品_SalesPrice_Parts = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    販売定価_α_SalesPrice_Alpha = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    販売定価_取付枠_SalesPrice_MountingFrame = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    販売定価_プレート_SalesPrice_Plate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_部品_CostRate_Parts = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_α_CostRate_Alpha = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_取付枠_CostRate_MountingFrame = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_プレート_CostRate_Plate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_UnitRate = table.Column<float>(type: "real", nullable: true),
                    ハンドルFLG_HandleFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    絶縁枠FLG_InsulationFrameFlag = table.Column<bool>(type: "bit", nullable: true),
                    プレートNo_PlateNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    プレート種類_PlateType = table.Column<byte>(type: "tinyint", nullable: true),
                    種別_Category = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_MsgTable",
                columns: table => new
                {
                    MsgCD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MsgPattern = table.Column<byte>(type: "tinyint", nullable: true),
                    MsgLine = table.Column<short>(type: "smallint", nullable: true),
                    Msg1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Msg2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Msg3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Msg4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Msg5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Command = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_PaperSize",
                columns: table => new
                {
                    No = table.Column<short>(type: "smallint", nullable: true),
                    PaperSize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_グループ名マスタ_TM_GroupNameMaster",
                columns: table => new
                {
                    GPCD = table.Column<int>(type: "int", nullable: true),
                    表示順 = table.Column<int>(type: "int", nullable: true),
                    GP名 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    選択FLG = table.Column<bool>(type: "bit", nullable: true),
                    仕入先CD1 = table.Column<int>(type: "int", nullable: true),
                    仕入先CD2 = table.Column<int>(type: "int", nullable: true),
                    仕入先CD3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_ファンクション_TM_Functions",
                columns: table => new
                {
                    Function01 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function02 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function03 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function04 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function05 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function06 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function07 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function08 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function09 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Function10 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_メーカーマスタ_TM_MakerMaster",
                columns: table => new
                {
                    メーカーCD_ManufacturerCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    メーカー名_ManufacturerName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_ランクマスタ_TM_RankMaster",
                columns: table => new
                {
                    ランク名_RankName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ランクCD_RankCode = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    乗率_Multiplier = table.Column<float>(type: "real", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_ランクマスタ_TM_RankMaster", x => x.ランク名_RankName);
                });

            migrationBuilder.CreateTable(
                name: "TM_仕入先マスタ_TM_VendorMaster",
                columns: table => new
                {
                    仕入先CD_SupplierCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    グループCD_GroupCode = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    フリガナ_Furigana = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    仕入先名_SupplierName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    支社名_BranchName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    郵便番号_PostalCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    都道府県CD_PrefectureCode = table.Column<int>(type: "int", nullable: true),
                    都道府県名_PrefectureName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    市町村CD_MunicipalityCode = table.Column<int>(type: "int", nullable: true),
                    市町村名_MunicipalityName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    住所1_Address1 = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    住所2_Address2 = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    電話番号1_Telephone1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    電話番号2_Telephone2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    締切日_ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ランク_Rank = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    FAX1_Fax1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FAX2_Fax2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    eメール_Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HPアドレス_HomepageAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    担当者_PersonInCharge = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    出力帳票形式1_OutputReportFormat1 = table.Column<int>(type: "int", nullable: true),
                    出力帳票形式2_OutputReportFormat2 = table.Column<int>(type: "int", nullable: true),
                    請求初期FLG_InitialBillingFlag = table.Column<bool>(type: "bit", nullable: true),
                    積算初期FLG_InitialEstimationFlag = table.Column<bool>(type: "bit", nullable: true),
                    備考_Remarks = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_仕入先マスタ_TM_VendorMaster", x => x.仕入先CD_SupplierCode);
                });

            migrationBuilder.CreateTable(
                name: "TM_付帯分類マスタ_AuxiliaryCategoryMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    素材名_MaterialName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GP番号1_GPNumber1 = table.Column<byte>(type: "tinyint", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_付帯分類マスタ_TM_AncillaryClassificationMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    素材名_MaterialName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    GP番号1_GPNumber1 = table.Column<byte>(type: "tinyint", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_分類1マスタ_Category1Master",
                columns: table => new
                {
                    分類1_Category1 = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_分類2マスタ_Category2Master",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    追加FLG_AdditionalFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_分類3マスタ_Category3Master",
                columns: table => new
                {
                    分類1_Category1 = table.Column<int>(type: "int", nullable: true),
                    分類2_Category2 = table.Column<int>(type: "int", nullable: true),
                    分類3_Category3 = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_分類4マスタ_Category4Master",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_単位マスタ_TM_UnitMaster",
                columns: table => new
                {
                    単位CD_UnitCode = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    単位名_UnitName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_合成単価マスタ_TM_SyntheticUnitPriceMaster",
                columns: table => new
                {
                    素材CD_MaterialCode = table.Column<int>(type: "int", nullable: true),
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_WorkRate = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    補助FLG_AuxiliaryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    補助_Auxiliary = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_名称マスタ_TM_NameMaster",
                columns: table => new
                {
                    名称CD_NameCode = table.Column<byte>(type: "tinyint", nullable: true),
                    名称番号_NameNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    名称_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_変換単位マスタ_TMUnitConversionMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<double>(type: "float", nullable: true),
                    分類2_Category2 = table.Column<double>(type: "float", nullable: true),
                    分類3_Category3 = table.Column<double>(type: "float", nullable: true),
                    分類4_Category4 = table.Column<double>(type: "float", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    変換単位CD_ConversionUnitCode = table.Column<short>(type: "smallint", nullable: true),
                    変換単位_ConversionUnit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    変換係数_ConversionCoefficient = table.Column<float>(type: "real", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_変換塗装マスタ_TMPaintingConversionMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<double>(type: "float", nullable: true),
                    分類2_Category2 = table.Column<double>(type: "float", nullable: true),
                    分類3_Category3 = table.Column<double>(type: "float", nullable: true),
                    分類4_Category4 = table.Column<double>(type: "float", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    塗料_Paint = table.Column<float>(type: "real", nullable: true),
                    HP_HP = table.Column<float>(type: "real", nullable: true),
                    歩掛_LaborCost = table.Column<float>(type: "real", nullable: true),
                    表面積_SurfaceArea = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_変換塗装単価マスタ_TM_PaintingConversionUnitPriceMaster",
                columns: table => new
                {
                    塗装CD_PaintCode = table.Column<short>(type: "smallint", nullable: true),
                    塗装名称_PaintName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    金額1_Amount1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    塗装FLG_PaintFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_変換歩掛マスタ_TM_ConversionWorkRateMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<double>(type: "float", nullable: true),
                    分類2_Category2 = table.Column<double>(type: "float", nullable: true),
                    分類3_Category3 = table.Column<double>(type: "float", nullable: true),
                    分類4_Category4 = table.Column<double>(type: "float", nullable: true),
                    変換歩掛CD_ConversionWorkRateCode = table.Column<byte>(type: "tinyint", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    歩掛_WorkRate = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_変換歩掛名称マスタ_TM_ConversionWorkRateNameMaster",
                columns: table => new
                {
                    変換歩掛CD_ConversionWorkRateCode = table.Column<byte>(type: "tinyint", nullable: true),
                    変換歩掛名称_ConversionWorkRateName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    略称_Abbreviation = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_家電分類1マスタ_TM_HomeApplianceClassification1Master",
                columns: table => new
                {
                    分類1_Category = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    データ名_DataName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_家電分類2マスタ_TM_HomeApplianceClassification2Master",
                columns: table => new
                {
                    分類1_Category = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category = table.Column<short>(type: "smallint", nullable: true),
                    家電CD_ApplianceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    データ名_DataName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true),
                    標準単価_StandardPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_工事名マスタ_TM_Constructionnamemaster",
                columns: table => new
                {
                    工事CD_ConstructionCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    工事名_ConstructionName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_工種マスタ_TM_ConstructionTypeMaster",
                columns: table => new
                {
                    工種CD_WorkTypeCode = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    工種名_WorkTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_市町村マスタ_TM_MunicipalityMaster",
                columns: table => new
                {
                    都道府県CD_PrefectureCode = table.Column<short>(type: "smallint", nullable: true),
                    場所分類1_LocationCategory1 = table.Column<short>(type: "smallint", nullable: true),
                    場所分類2_LocationCategory2 = table.Column<short>(type: "smallint", nullable: true),
                    場所分類3_LocationCategory3 = table.Column<short>(type: "smallint", nullable: true),
                    場所名_LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    削除フラグ_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_役職マスタ_TM_JobMaster",
                columns: table => new
                {
                    役職CD_PositionCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    役職名_PositionName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_得意先マスタ_CustomerMaster",
                columns: table => new
                {
                    得意先CD_CustomerCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    グループCD_GroupCode = table.Column<int>(type: "int", nullable: false),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    フリガナ_Furigana = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    得意先名_CustomerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    支社名_BranchName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    郵便番号_PostalCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    都道府県名_PrefectureName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    市町村CD_CityCode = table.Column<int>(type: "int", nullable: true),
                    市町村名_CityName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    住所1_Address1 = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    住所2_Address2 = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    電話番号1_PhoneNumber1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    電話番号2_PhoneNumber2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    締切日_ClosingDate = table.Column<byte>(type: "tinyint", nullable: true),
                    ランク_Rank = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    FAX1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FAX2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    eメール_Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HPアドレス_HomepageAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    担当者_PersonInCharge = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    出力帳票形式1_OutputReportFormat1 = table.Column<byte>(type: "tinyint", nullable: true),
                    出力帳票形式2_OutputReportFormat2 = table.Column<byte>(type: "tinyint", nullable: true),
                    請求初期FLG_InitialBillingFlag = table.Column<bool>(type: "bit", nullable: true),
                    積算初期FLG_InitialEstimationFlag = table.Column<bool>(type: "bit", nullable: true),
                    備考_Remarks = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM_得意先マスタ_CustomerMaster", x => x.得意先CD_CustomerCode);
                });

            migrationBuilder.CreateTable(
                name: "TM_支給区分マスタ_TM_PaymentClassificationMaster",
                columns: table => new
                {
                    支給区分CD_ProvisionCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_ProvisionCategoryName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    歩掛係数_WorkRateCoefficient = table.Column<float>(type: "real", nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_明細戻り_TM_ItemReturn",
                columns: table => new
                {
                    分類_Category = table.Column<byte>(type: "tinyint", nullable: true),
                    CD_Code = table.Column<short>(type: "smallint", nullable: true),
                    名称_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_明細補助マスタ_TM_AuxiliaryItemMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<double>(type: "float", nullable: true),
                    分類2_Category2 = table.Column<double>(type: "float", nullable: true),
                    分類3_Category3 = table.Column<double>(type: "float", nullable: true),
                    分類4_Category4 = table.Column<double>(type: "float", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    明細補助F_DetailSupplementF = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    明細補助B_DetailSupplementB = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_暦マスタ_TM_CalendarMaster",
                columns: table => new
                {
                    暦CD_CalendarCode = table.Column<byte>(type: "tinyint", nullable: true),
                    暦名_CalendarName = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    変更年_ChangeYear = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_歩掛補正マスタ_TM_WalkCorrectionMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    補助名_AuxiliaryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    補助FLG1_AuxiliaryFlag1 = table.Column<byte>(type: "tinyint", nullable: true),
                    補助FLG2_AuxiliaryFlag2 = table.Column<byte>(type: "tinyint", nullable: true),
                    削除FLG_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_消費税_TM_ConsumptionTax",
                columns: table => new
                {
                    税CD_TaxCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    税名_TaxName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    税率_TaxRate = table.Column<float>(type: "real", nullable: true),
                    開始期間_StartPeriod = table.Column<DateTime>(type: "datetime", nullable: true),
                    終了期間_EndPeriod = table.Column<DateTime>(type: "datetime", nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_特殊分類1マスタ_TM_ SpecialClassification1Master",
                columns: table => new
                {
                    分類1_Classification1 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    データ名_DataName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_特殊分類2マスタ_TM_SpecialClassification2Master",
                columns: table => new
                {
                    分類1_Classification1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Classification2 = table.Column<short>(type: "smallint", nullable: true),
                    特殊CD_SpecialCode = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    データ名_DataName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    集計FLG_AggregationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true),
                    標準単価_StandardUnitPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_特記事項マスタ_TM_SpecialNoteMaster",
                columns: table => new
                {
                    特記事項CD_SpecialNotesCode = table.Column<short>(type: "smallint", nullable: true),
                    分類CD_CategoryCode = table.Column<byte>(type: "tinyint", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    特記事項名_SpecialNotesName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_素材マスタ_TM_MaterialMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<int>(type: "int", nullable: true),
                    分類2_Category2 = table.Column<int>(type: "int", nullable: true),
                    分類3_Category3 = table.Column<int>(type: "int", nullable: true),
                    分類4_Category4 = table.Column<int>(type: "int", nullable: true),
                    素材CD_MaterialCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    部材名_PartName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmissionUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    建物単価_BuildingUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電設資材_ElectricalInstallationMaterial = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電設乗率_ElectricalInstallationRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    電設原価率_ElectricalInstallationCostRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    補給率_SupplyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    付属品率_AccessoryRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_WorkRateA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    撤去率A_RemovalRateA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_WorkRateB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    撤去率B_RemovalRateB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    その他_Other = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    単位CD_UnitCode = table.Column<int>(type: "int", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<int>(type: "int", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ABC材_ABC_Material = table.Column<int>(type: "int", nullable: true),
                    更新日付_UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    更新者_Updater = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    天井開口費_CeilingOpeningCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_素材分類ヘッダ_TM_MaterialClassificationHeader",
                columns: table => new
                {
                    分類番号_CategoryNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_素材分類マスタ_TM_MaterialClassificationMaster",
                columns: table => new
                {
                    分類番号_CategoryNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    NetFLG_NetFlag = table.Column<bool>(type: "bit", nullable: true),
                    乗率標準設定_RateStandardSetting = table.Column<float>(type: "real", nullable: true),
                    原価率標準設定_CostRateStandardSetting = table.Column<float>(type: "real", nullable: true),
                    GP番号1_GPNumber1 = table.Column<byte>(type: "tinyint", nullable: true),
                    GP番号2_GPNumber2 = table.Column<byte>(type: "tinyint", nullable: true),
                    GP番号3_GPNumber3 = table.Column<byte>(type: "tinyint", nullable: true),
                    GP番号4_GPNumber4 = table.Column<bool>(type: "bit", nullable: true),
                    表示素材分類名_DisplayedMaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    その他率設定_OtherRateSetting = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_経費ランクマスタ_TM_ExpenseRankMaster",
                columns: table => new
                {
                    ランクCD_RankCode = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    労務単価A_LaborCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務単価B_LaborCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費率_SiteMiscellaneousRate = table.Column<float>(type: "real", nullable: true),
                    諸経費率_OtherExpensesRate = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_補助マスタ_TM_Auxiliary_SupportMaster",
                columns: table => new
                {
                    補助CD_SupportCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    補助名_SupportName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    補助FLG1_SupportFlag1 = table.Column<byte>(type: "tinyint", nullable: true),
                    補助FLG2_SupportFlag2 = table.Column<byte>(type: "tinyint", nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_資格マスタ_TM_QualificationMaster",
                columns: table => new
                {
                    資格CD_QualificationCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    資格名_QualificationName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_追加品目マスタ_TM_AdditionalMaterialMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    素材CD_MaterialCode = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    素材名_MaterialName = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmissionUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    建物単価_BuildingUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedResourceUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_WorkRateA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_WorkRateB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    素材分類CD_MaterialClassificationCode = table.Column<short>(type: "smallint", nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true),
                    天井開口費_CeilingOpeningCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    更新日付_UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    更新者_UpdatedBy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_都道府県マスタ_PrefectureMaster",
                columns: table => new
                {
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    都道府県名_PrefectureName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    都道府県分類_PrefectureCategory = table.Column<byte>(type: "tinyint", nullable: true),
                    削除フラグ_DeletionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_都道府県マスタ_TM_ StateandProvinceMaster",
                columns: table => new
                {
                    都道府県CD_PrefectureCode = table.Column<byte>(type: "tinyint", nullable: true),
                    都道府県名_PrefectureName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    都道府県分類_PrefectureCategory = table.Column<byte>(type: "tinyint", nullable: true),
                    削除フラグ_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_配線器具マスタ_TM_WiringFixtureMaster",
                columns: table => new
                {
                    配線器具種別_WiringDeviceType = table.Column<byte>(type: "tinyint", nullable: true),
                    配線分類CD_WiringClassificationCode = table.Column<short>(type: "smallint", nullable: true),
                    配線分類名称_WiringClassificationName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    配線器具CD_WiringDeviceCode = table.Column<short>(type: "smallint", nullable: true),
                    配線器具名称_WiringDeviceName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    分類CD_ClassificationCode = table.Column<byte>(type: "tinyint", nullable: true),
                    プレートCD_PlateCode = table.Column<byte>(type: "tinyint", nullable: true),
                    ハンドルFLG_HandleFlag = table.Column<bool>(type: "bit", nullable: true),
                    個口_Unit = table.Column<byte>(type: "tinyint", nullable: true),
                    歩掛_WorkRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    販売定価_SellingPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    取付枠FLG_MountingFrameFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    BackColor_BackgroundColor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_電工マスタ_TM_ElectricianMaster",
                columns: table => new
                {
                    電工CD_ElectricianCode = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    氏名_FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    労務単価_LaborUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    生年月日_DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    入社年月日_JoinDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    資格1_Qualification1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    資格2_Qualification2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    資格3_Qualification3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    役職_Position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    郵便番号_PostCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    住所1_AddressLine1 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    住所2_AddressLine2 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    電話番号1_PhoneNumber1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    電話番号2_PhoneNumber2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    携帯電話1_MobilePhone1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    携帯電話2_MobilePhone2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    削除FLG_DeleteFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_電線まとめマスタ_TM_WireSummaryMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    まとめCD_SummaryCode = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_内訳明細データ_DetailedBreakdownData",
                columns: table => new
                {
                    GP番号 = table.Column<int>(type: "int", nullable: true),
                    表示順 = table.Column<int>(type: "int", nullable: true),
                    No = table.Column<short>(type: "smallint", nullable: true),
                    工種番号 = table.Column<int>(type: "int", nullable: true),
                    部材番号 = table.Column<short>(type: "smallint", nullable: true),
                    表示工種番号 = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    工種名 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    部材名1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    部材名2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    数量 = table.Column<float>(type: "real", nullable: true),
                    単位 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    単価 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    備考 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    合計フラグ = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_内訳複合データ_CompositeBreakdownData",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    ＧP番号_GPNumber = table.Column<int>(type: "int", nullable: true),
                    頁番号_PageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    番号_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_ShapeAndDimensions = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_QuotedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価A_CompositeUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価B_CompositeUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A_UnitLaborA = table.Column<float>(type: "real", nullable: true),
                    歩掛B_UnitLaborB = table.Column<float>(type: "real", nullable: true),
                    提出金額_QuotedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCD = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_内訳集計データ_ItemizedSummaryData",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    品名及び名称_ProductAndName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_ShapeDimensions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_ReplenishmentRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_QuotationQuantity = table.Column<float>(type: "real", nullable: true),
                    NETRate_NET率 = table.Column<float>(type: "real", nullable: true),
                    社内数量_InHouseQuantity = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分名_PaymentCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_LoadingRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_QuotationUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_WorkRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    提出金額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    改頁FLG_PageBreakFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_分類別複合データ_CategorywiseCompositeData",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    ＧP番号_GPNumber = table.Column<int>(type: "int", nullable: true),
                    頁番号_PageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    番号_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合金額_CompositeAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価A_UnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価B_UnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_FillRate = table.Column<float>(type: "real", nullable: true),
                    付属率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousRate = table.Column<float>(type: "real", nullable: true),
                    歩掛1_ManHourRate1 = table.Column<float>(type: "real", nullable: true),
                    歩掛2_ManHourRate2 = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    社内単価_InHouseUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_分類別集計データ_TR_CategorywiseSummaryData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_WorkTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    品名及び名称_ItemAndName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_SubmittedQuantity = table.Column<float>(type: "real", nullable: true),
                    NET率_NETRate = table.Column<float>(type: "real", nullable: true),
                    社内数量_InternalQuantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_LoadRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_ManHours = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_工種明細データ_WorkTypeDetailData",
                columns: table => new
                {
                    GP番号_GPNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    No_SequenceNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    工種名1_WorkTypeName1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工種名2_WorkTypeName2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額_TotalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    備考_Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    合計フラグ_TotalFlag = table.Column<bool>(type: "bit", nullable: true),
                    予備1_Reserve1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_比較表データ_ComparisonTableData",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    ＧP番号_GPNumber = table.Column<int>(type: "int", nullable: true),
                    頁番号_PageNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補助_Support = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    単価1_UnitPrice1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額1_Amount1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    製作所名1_ManufacturerName1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    単価2_UnitPrice2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額2_Amount2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    製作所名2_ManufacturerName2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    単価3_UnitPrice3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    金額3_Amount3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    製作所名3_ManufacturerName3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    採用製作所名_SelectedManufacturerName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    掛率_DiscountRate = table.Column<byte>(type: "tinyint", nullable: true),
                    合計フラグ_TotalFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_積算一覧データ_QuotationListData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    表示見積番号_DisplayQuotationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    提出先1_SubmitTo1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_SubmitTo2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称_ProjectName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事場所_ProjectLocation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    期限_Deadline = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    条件_Conditions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    見積額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費_MiscellaneousExpenses = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価_Cost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    粗利_GrossProfit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    作成者_Creator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    仕入先_Supplier = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    計算種別_CalculationType = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_積算印刷データ_QuotationPrintData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_WorkTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_SubmittedQuantity = table.Column<float>(type: "real", nullable: true),
                    NET率_NETRate = table.Column<float>(type: "real", nullable: true),
                    社内数量_InternalQuantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyTypeCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyTypeName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価計算FLG_PriceCalculationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    単価_Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_Rate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InternalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_StandardLabor = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_積算実行データ_QuotationExecutionData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号1_GPNumber1 = table.Column<byte>(type: "tinyint", nullable: true),
                    GP番号2_GPNumber2 = table.Column<byte>(type: "tinyint", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出工数_SubmittedWorkHours = table.Column<float>(type: "real", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内工数_InHouseWorkHours = table.Column<float>(type: "real", nullable: true),
                    提出総計_SubmittedTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内総計_InHouseTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_積算総括データ_QuotationSummaryData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    工事種目_ConstructionType = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    B材_A_MaterialB_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_A_Wires_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_A_MaterialA_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_A_DisasterPrevention_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_A_MiscellaneousMaterials_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_A_AdditionalWork_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_A_LaborCost_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_A_CommonCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費等_A_Expenses_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    小計_A_Subtotal_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    B材_B_MaterialB_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_B_Wires_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_B_MaterialA_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_B_DisasterPrevention_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_B_MiscellaneousMaterials_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_B_AdditionalWork_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_B_LaborCost_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_B_CommonCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費等_B_Expenses_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    小計_B_Subtotal_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_素材乗率データ_MaterialLoadingRateData",
                columns: table => new
                {
                    GP番号1_GPNumber1 = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順1_DisplayOrder1 = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名1_MaterialCategoryName1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    乗率設定1_LoadingRateSetting1 = table.Column<float>(type: "real", nullable: true),
                    原価率設定1_CostRateSetting1 = table.Column<float>(type: "real", nullable: true),
                    表示順2_DisplayOrder2 = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名2_MaterialCategoryName2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    乗率設定2_LoadingRateSetting2 = table.Column<float>(type: "real", nullable: true),
                    原価率設定2_CostRateSetting2 = table.Column<float>(type: "real", nullable: true),
                    表示順3_DisplayOrder3 = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名3_MaterialCategoryName3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    乗率設定3_LoadingRateSetting3 = table.Column<float>(type: "real", nullable: true),
                    原価率設定3_CostRateSetting3 = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_複合単価データ_CompositeUnitPriceData",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    ＧP番号_GPNumber = table.Column<int>(type: "int", nullable: true),
                    頁番号_PageNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    番号_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplenishmentRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoriesRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A_WorkEfficiencyA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛B_WorkEfficiencyB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価小計_CompositeUnitPriceSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補助_Supplementary = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    空白FLG_BlankFlag = table.Column<bool>(type: "bit", nullable: true),
                    合計フラグ_TotalFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_複合印刷データ_CompositePrintData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_AuthorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_ConstructionTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_ConstructionTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称_ProductAndName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_ShapeAndDimension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_QuotationQuantity = table.Column<float>(type: "real", nullable: true),
                    NET率_NETRate = table.Column<float>(type: "real", nullable: true),
                    社内数量_InHouseQuantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyDivisionCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyDivisionName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価計算FLG_UnitPriceCalculationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_LoadRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_QuotationUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_LaborRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    提出金額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TR_複合総括データ_CompositeSummaryData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_AuthorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    工事種目_ConstructionItem = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    B材_A_MaterialB_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_A_Wires_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_A_MaterialA_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_A_DisasterPrevention_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_A_MiscellaneousMaterials_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_A_AuxiliaryWork_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_A_LaborCost_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_A_CommonCost_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費等_A_ExpensesEtc_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    小計_A_Subtotal_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    B材_B_MaterialB_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_B_Wires_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_B_MaterialA_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_B_DisasterPrevention_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_B_MiscellaneousMaterials_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_B_AuxiliaryWork_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_B_LaborCost_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_B_CommonCost_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費等_B_ExpensesEtc_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    小計_B_Subtotal_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_ファンクション_Function",
                columns: table => new
                {
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    ファンクション名_FunctionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_合成単価データ_CombinedUnitPriceData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    補助番号_AssistanceNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_WorkRatio = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    補助FLG_AssistanceFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    補助_Assistance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_同一CD異単価チェック_SameCDDifferentUnitPriceCheck",
                columns: table => new
                {
                    部材No_MaterialNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    工種名_WorkTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    乗率_RateOfIncrease = table.Column<float>(type: "real", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    適用FLG_ApplicationFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_基礎データ_BasicData",
                columns: table => new
                {
                    身分証明書_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    表示見積番号_DisplayQuotationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    日付_Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    工事名称1_ConstructionName1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称2_ConstructionName2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先CD_QuotationDestinationCode = table.Column<int>(type: "int", nullable: true),
                    提出先1_QuotationDestination1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_QuotationDestination2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    作成者名_CreatorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    積算複合FLG_EstimationCompositeFlag = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TW_基礎データ_BasicData", x => x.身分証明書_ID);
                });

            migrationBuilder.CreateTable(
                name: "TW_工種データ_ConstructionTypeData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    工種FLG_ConstructionTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種枝1_ConstructionTypeBranch1 = table.Column<short>(type: "smallint", nullable: true),
                    工種枝2_ConstructionTypeBranch2 = table.Column<short>(type: "smallint", nullable: true),
                    工種枝3_ConstructionTypeBranch3 = table.Column<short>(type: "smallint", nullable: true),
                    工種Child_ConstructionTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    工種CD_WorkTypeCode = table.Column<int>(type: "int", nullable: true),
                    工種名_ConstructionTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    作成日付_CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    更新日付_UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    備考_Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_工種並替えワーク_WorkTypeReorderingWork",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    表示工種番号_DisplayWorkTypeNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    工種FLG_WorkTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    工種CD_WorkTypeCode = table.Column<int>(type: "int", nullable: true),
                    工種名_WorkTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗FLG_MiscellaneousMaterialConsumptionFlag = table.Column<bool>(type: "bit", nullable: true),
                    戸数_NumberOfUnits = table.Column<byte>(type: "tinyint", nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    機材費A_EquipmentCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    機材費B_EquipmentCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材消耗品費A_MiscellaneousMaterialConsumptionCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材消耗品費B_MiscellaneousMaterialConsumptionCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費A_LaborCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費B_LaborCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事A_AdditionalWorkA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事B_AdditionalWorkB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費A_CommonCostA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費B_CommonCostB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費A_OnSiteMiscellaneousExpensesA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費B_OnSiteMiscellaneousExpensesB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費A_VariousExpensesA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費B_VariousExpensesB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    正表示順_CorrectDisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_引用部材乗率データ_ReferencedMaterialLoadingRateData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    案_Plan = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_ConstructionTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_Dimension = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_FillRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_SubmittedQuantity = table.Column<float>(type: "real", nullable: true),
                    NET率_NETRate = table.Column<float>(type: "real", nullable: true),
                    社内数量_InHouseQuantity = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価計算FLG_PriceCalculationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    単価_Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_LoadingRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InHousePrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛_WorkHours = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    塗装係数_PaintingCoefficient = table.Column<float>(type: "real", nullable: true),
                    天井開口係数_CeilingOpeningCoefficient = table.Column<float>(type: "real", nullable: true),
                    提出金額_QuotationAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InHouseAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    新工種番号_NewWorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    新部材番号_NewMaterialNumber = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_明細分析データ_DetailAnalysisData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    GP番号_GPNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    B材_A_MaterialB_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_A_Wires_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_A_MaterialA_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_A_DisasterPrevention_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_A_MiscMaterials_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_A_LaborCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    外注費_A_SubcontractingCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_A_AccessoryWork_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_A_CommonCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費_A_SiteMiscellaneousCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費_A_VariousCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通仮設費_A_CommonTemporaryCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場管理費_A_SiteManagementCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    一般管理費_A_GeneralManagementCosts_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    材料小計_A_MaterialSubtotal_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務小計_A_LaborSubtotal_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費小計_A_CostSubtotal_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    総計_A_Total_A = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    B材_B_MaterialB_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電線類_B_Wires_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    A材_B_MaterialA_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    雑材_B_MiscMaterials_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    防災_B_DisasterPrevention_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費_B_LaborCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    外注費_B_SubcontractingCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付帯工事_B_AccessoryWork_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通費_B_CommonCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場雑費_B_SiteMiscellaneousCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    諸経費_B_VariousCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    共通仮設費_B_CommonTemporaryCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    現場管理費_B_SiteManagementCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    一般管理費_B_GeneralManagementCosts_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    材料小計_B_MaterialSubtotal_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務小計_B_LaborSubtotal_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    経費小計_B_CostSubtotal_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    総計_B_Total_B = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_検索素材マスタ_SearchMaterialMaster",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    マスタFLG_MasterFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    素材CD_MaterialCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    部材名_ComponentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_QuotedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InHouseUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    建物単価_BuildingUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedMaterialUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電設資材_ElectricalMaterials = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    電設乗率_ElectricalLoadingRate = table.Column<float>(type: "real", nullable: true),
                    電設原価率_ElectricalCostRate = table.Column<float>(type: "real", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_WorkRateA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_WorkRateB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    更新日付_UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    更新者_Updater = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    天井開口費_CeilingOpeningCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_比較データ_ComparisonData",
                columns: table => new
                {
                    見積番号_EstimateNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Group番号_GroupNumber = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    単価1_UnitPrice1 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価2_UnitPrice2 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単価3_UnitPrice3 = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_RateOfIncrease = table.Column<float>(type: "real", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_比較基本データ_ComparisonBasicData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    製作所名1_ManufacturerName1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    製作所名2_ManufacturerName2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    製作所名3_ManufacturerName3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    採用製作所名_SelectedManufacturerName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    掛率_MultiplicationRate = table.Column<byte>(type: "tinyint", nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    頁_Page = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_積算集計データ_EstimationSummaryData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    案_Scenario = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類FLG_CategoryFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_WorkTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    提出数量_QuotedQuantity = table.Column<float>(type: "real", nullable: true),
                    NET率_NETRate = table.Column<float>(type: "real", nullable: true),
                    社内数量_InternalQuantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    単価計算FLG_UnitPriceCalculationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    単価_UnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_Rate = table.Column<float>(type: "real", nullable: true),
                    提出単価_QuotedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    付属品率_AdditionalRate = table.Column<float>(type: "real", nullable: true),
                    歩掛_WorkHoursRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    塗装係数_PaintingCoefficient = table.Column<float>(type: "real", nullable: true),
                    天井開口係数_CeilingOpeningCoefficient = table.Column<float>(type: "real", nullable: true),
                    提出金額_QuotedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_総合複合単価ワーク_OverallCompositeUnitPriceWork",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    補助番号_AssistanceNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    補助表示順_AssistanceDisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    建物単価_BuildingUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedMaterialUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AdditionalRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A_WorkHoursRateA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛B_WorkHoursRateB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価小計_CompositeUnitPriceSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補助FLG_AssistanceFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    補助_Assistance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    入力FLG_InputFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_製作所データ_ProducersData",
                columns: table => new
                {
                    No_Number = table.Column<short>(type: "smallint", nullable: true),
                    製作所名_ProducersName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_複合単価データ_CompositeUnitPriceData",
                columns: table => new
                {
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_ConstructionTypeCode = table.Column<short>(type: "smallint", nullable: true),
                    部材番号_MaterialCode = table.Column<short>(type: "smallint", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    補助番号_SupportNumber = table.Column<int>(type: "int", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    補助表示順_SupportDisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    建物単価_BuildingPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedMaterialPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborPriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A_WorkRateA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborPriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛B_WorkRateB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Others = table.Column<float>(type: "real", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価小計_CompositePriceSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補助FLG_SupportFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    補助_Support = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    入力FLG_InputFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_複合率設定データ_CompositeRateSettingData",
                columns: table => new
                {
                    工種番号_ConstructionTypeCode = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialCode = table.Column<short>(type: "smallint", nullable: true),
                    案_Plan = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    歩掛A_WorkRateA = table.Column<float>(type: "real", nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_複合集計データ_CompositeAggregationData",
                columns: table => new
                {
                    見積番号_EstimateNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeCode = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialCode = table.Column<short>(type: "smallint", nullable: true),
                    案_Plan = table.Column<byte>(type: "tinyint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    分類FLG_ClassFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種FLG_WorkTypeFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    工種Child_WorkTypeChild = table.Column<byte>(type: "tinyint", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    品名及び名称_ItemNameAndDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    項目_Item = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    形状寸法_Dimension = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    補給率_SupplyRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材消耗率_MiscellaneousMaterialConsumptionRate = table.Column<float>(type: "real", nullable: true),
                    その他_Others = table.Column<float>(type: "real", nullable: true),
                    単価計算FLG_PriceCalculationFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    単価_Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    乗率_Multiplier = table.Column<float>(type: "real", nullable: true),
                    原価率_CostRate = table.Column<float>(type: "real", nullable: true),
                    提出単価_SubmittedPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価A_CompositePriceA = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価B_CompositePriceB = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    歩掛A_WorkRateA = table.Column<float>(type: "real", nullable: true),
                    歩掛B_WorkRateB = table.Column<float>(type: "real", nullable: true),
                    電工単価_ElectricalWorkPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    普作単価_StandardWorkPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    比較表FLG_ComparisonTableFlag = table.Column<bool>(type: "bit", nullable: true),
                    塗装係数_PaintingCoefficient = table.Column<float>(type: "real", nullable: true),
                    天井開口係数_CeilingOpeningCoefficient = table.Column<float>(type: "real", nullable: true),
                    提出金額_SubmittedAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内金額_InternalAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_見積一覧ワーク_WorkQuotationSummary",
                columns: table => new
                {
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    見積番号_QuotationNumber = table.Column<int>(type: "int", nullable: true),
                    表示見積番号_DisplayQuotationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    提出先_QuotationDestination = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    提出先1_QuotationDestination1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    提出先2_QuotationDestination2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    工事名称_ProjectName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    作成者_Creator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    仕入先_Supplier = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_計算式_CalculationFormula",
                columns: table => new
                {
                    No_Number = table.Column<byte>(type: "tinyint", nullable: true),
                    計算項目_CalculationItem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    表示FLG_DisplayFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_追加並替えワーク_AdditionalReorderingWork",
                columns: table => new
                {
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    素材CD_MaterialCode = table.Column<int>(type: "int", nullable: true),
                    分類名_CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    素材名_MaterialName = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    建物単価_BuildingUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    積資単価_AccumulatedMaterialUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AdditionalRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_WorkHoursRateA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_WorkHoursRateB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    明細FLG_DetailFlag = table.Column<bool>(type: "bit", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    正表示順_CorrectDisplayOrder = table.Column<int>(type: "int", nullable: true),
                    選択FLG_SelectionFlag = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_部材データ_MaterialsData",
                columns: table => new
                {
                    見積番号_EstimateNumber = table.Column<int>(type: "int", nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材FLG_MaterialFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    分類1_Category1 = table.Column<int>(type: "int", nullable: true),
                    分類2_Category2 = table.Column<int>(type: "int", nullable: true),
                    分類3_Category3 = table.Column<int>(type: "int", nullable: true),
                    分類4_Category4 = table.Column<int>(type: "int", nullable: true),
                    分類5_Category5 = table.Column<int>(type: "int", nullable: true),
                    分類6_Category6 = table.Column<int>(type: "int", nullable: true),
                    分類7_Category7 = table.Column<int>(type: "int", nullable: true),
                    分類8_Category8 = table.Column<int>(type: "int", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名5_MaterialName5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名6_MaterialName6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名7_MaterialName7 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名8_MaterialName8 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_LaborCostA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_LaborCostB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価小計_CompositeUnitPriceSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補助FLG_AssistanceFlag = table.Column<byte>(type: "tinyint", nullable: true),
                    補助_Assistance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    入力FLG_InputFlag = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_部材並替えワーク1_MaterialReorderingWork1",
                columns: table => new
                {
                    見積番号_EstimateNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_WorkTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    分類1No_Category1Number = table.Column<short>(type: "smallint", nullable: true),
                    分類2No_Category2Number = table.Column<short>(type: "smallint", nullable: true),
                    分類3No_Category3Number = table.Column<short>(type: "smallint", nullable: true),
                    分類4No_Category4Number = table.Column<short>(type: "smallint", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材明細_MaterialDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    部材GRP_MaterialGroup = table.Column<byte>(type: "tinyint", nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    塗装費_PaintingCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    天井開口_CeilingOpening = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_QuotedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_LaborCostA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_LaborCostB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_部材並替えワーク2_MaterialReorderingWork2",
                columns: table => new
                {
                    見積番号_QuotedNumber = table.Column<int>(type: "int", nullable: true),
                    作成者CD_CreatorCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    工種番号_ConstructionTypeNumber = table.Column<int>(type: "int", nullable: true),
                    部材番号_MaterialNumber = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    部材FLG_MaterialFlag = table.Column<short>(type: "smallint", nullable: true),
                    分類1_Category1 = table.Column<short>(type: "smallint", nullable: true),
                    分類2_Category2 = table.Column<short>(type: "smallint", nullable: true),
                    分類3_Category3 = table.Column<short>(type: "smallint", nullable: true),
                    分類4_Category4 = table.Column<short>(type: "smallint", nullable: true),
                    分類1No_Category1Number = table.Column<short>(type: "smallint", nullable: true),
                    分類2No_Category2Number = table.Column<short>(type: "smallint", nullable: true),
                    分類3No_Category3Number = table.Column<short>(type: "smallint", nullable: true),
                    分類4No_Category4Number = table.Column<short>(type: "smallint", nullable: true),
                    部材名_MaterialName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    部材名1_MaterialName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名2_MaterialName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名3_MaterialName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材名4_MaterialName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    部材明細_MaterialDetails = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    形状寸法_Dimensions = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    部材GRP_MaterialGroup = table.Column<byte>(type: "tinyint", nullable: true),
                    数量_Quantity = table.Column<float>(type: "real", nullable: true),
                    金額_Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    単位CD_UnitCode = table.Column<short>(type: "smallint", nullable: true),
                    単位_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    支給区分CD_SupplyCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    支給区分名_SupplyCategoryName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    塗装費_PaintingCost = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    天井開口_CeilingOpening = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    標準単価_StandardUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    提出単価_SubmittedUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    社内単価_InternalUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    複合単価_CompositeUnitPrice = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    補給率_ReplacementRate = table.Column<float>(type: "real", nullable: true),
                    付属品率_AccessoryRate = table.Column<float>(type: "real", nullable: true),
                    雑材率_MiscellaneousMaterialRate = table.Column<float>(type: "real", nullable: true),
                    労務単価A_LaborUnitPriceA = table.Column<int>(type: "int", nullable: true),
                    歩掛A_LaborCostA = table.Column<float>(type: "real", nullable: true),
                    撤去率A_RemovalRateA = table.Column<float>(type: "real", nullable: true),
                    労務単価B_LaborUnitPriceB = table.Column<int>(type: "int", nullable: true),
                    歩掛B_LaborCostB = table.Column<float>(type: "real", nullable: true),
                    撤去率B_RemovalRateB = table.Column<float>(type: "real", nullable: true),
                    その他_Other = table.Column<float>(type: "real", nullable: true),
                    材料費小計_MaterialCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    労務費小計_LaborCostSubtotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    素材分類CD_MaterialCategoryCode = table.Column<short>(type: "smallint", nullable: true),
                    素材分類名_MaterialCategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ABC材_ABCMaterial = table.Column<byte>(type: "tinyint", nullable: true),
                    正表示順_CorrectDisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_部署データ_DepartmentData",
                columns: table => new
                {
                    部署CD_DepartmentCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    部署名_DepartmentName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TW_集計工種選択_AggregationWorkTypeSelection",
                columns: table => new
                {
                    工種番号_WorkTypeNumber = table.Column<short>(type: "smallint", nullable: true),
                    表示順_DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    工種名_WorkTypeName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                });
            **/
            #endregion 
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserCD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserCD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserCD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserCD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "T_ErrorList");

            migrationBuilder.DropTable(
                name: "T_TablePath");

            migrationBuilder.DropTable(
                name: "TC_ZIP");

            migrationBuilder.DropTable(
                name: "TC_データテーブル一覧");

            migrationBuilder.DropTable(
                name: "TC_見積情報");

            migrationBuilder.DropTable(
                name: "TC_部署データ");

            migrationBuilder.DropTable(
                name: "TI_基礎データ_BasicData");

            migrationBuilder.DropTable(
                name: "TI_工種データ_ConstructionTypeData");

            migrationBuilder.DropTable(
                name: "TI_比較GP名データ_ComparisonGroupNameData");

            migrationBuilder.DropTable(
                name: "TI_比較データ_ComparisonData");

            migrationBuilder.DropTable(
                name: "TI_比較基本データ_ComparisonBasicData");

            migrationBuilder.DropTable(
                name: "TI_積算表紙データ_EstimatedGeneralData");

            migrationBuilder.DropTable(
                name: "TI_積算集計データ_EstimatedAggregationData");

            migrationBuilder.DropTable(
                name: "TI_積算集計ヘッダ_EstimatedAggregationHeader");

            migrationBuilder.DropTable(
                name: "TI_素材その他データMaterialAndAdditionalData");

            migrationBuilder.DropTable(
                name: "TI_素材乗率データMaterialLoadRatioData");

            migrationBuilder.DropTable(
                name: "TI_複合表紙データ_CompositCoverData");

            migrationBuilder.DropTable(
                name: "TI_複合集計データ_CompositAggregationData");

            migrationBuilder.DropTable(
                name: "TI_複合集計ヘッダ_CompositeAggregationHeader");

            migrationBuilder.DropTable(
                name: "TI_部材データ_MaterialsData");

            migrationBuilder.DropTable(
                name: "TI_配線器具個数データ_WiringDeviceQuantityData");

            migrationBuilder.DropTable(
                name: "TI_配線器具単価データ_WiringDeviceUintPriceData");

            migrationBuilder.DropTable(
                name: "TM_MsgTable");

            migrationBuilder.DropTable(
                name: "TM_PaperSize");

            migrationBuilder.DropTable(
                name: "TM_グループ名マスタ_TM_GroupNameMaster");

            migrationBuilder.DropTable(
                name: "TM_ファンクション_TM_Functions");

            migrationBuilder.DropTable(
                name: "TM_メーカーマスタ_TM_MakerMaster");

            migrationBuilder.DropTable(
                name: "TM_ランクマスタ_TM_RankMaster");

            migrationBuilder.DropTable(
                name: "TM_仕入先マスタ_TM_VendorMaster");

            migrationBuilder.DropTable(
                name: "TM_付帯分類マスタ_AuxiliaryCategoryMaster");

            migrationBuilder.DropTable(
                name: "TM_付帯分類マスタ_TM_AncillaryClassificationMaster");

            migrationBuilder.DropTable(
                name: "TM_分類1マスタ_Category1Master");

            migrationBuilder.DropTable(
                name: "TM_分類2マスタ_Category2Master");

            migrationBuilder.DropTable(
                name: "TM_分類3マスタ_Category3Master");

            migrationBuilder.DropTable(
                name: "TM_分類4マスタ_Category4Master");

            migrationBuilder.DropTable(
                name: "TM_単位マスタ_TM_UnitMaster");

            migrationBuilder.DropTable(
                name: "TM_合成単価マスタ_TM_SyntheticUnitPriceMaster");

            migrationBuilder.DropTable(
                name: "TM_名称マスタ_TM_NameMaster");

            migrationBuilder.DropTable(
                name: "TM_変換単位マスタ_TMUnitConversionMaster");

            migrationBuilder.DropTable(
                name: "TM_変換塗装マスタ_TMPaintingConversionMaster");

            migrationBuilder.DropTable(
                name: "TM_変換塗装単価マスタ_TM_PaintingConversionUnitPriceMaster");

            migrationBuilder.DropTable(
                name: "TM_変換歩掛マスタ_TM_ConversionWorkRateMaster");

            migrationBuilder.DropTable(
                name: "TM_変換歩掛名称マスタ_TM_ConversionWorkRateNameMaster");

            migrationBuilder.DropTable(
                name: "TM_家電分類1マスタ_TM_HomeApplianceClassification1Master");

            migrationBuilder.DropTable(
                name: "TM_家電分類2マスタ_TM_HomeApplianceClassification2Master");

            migrationBuilder.DropTable(
                name: "TM_工事名マスタ_TM_Constructionnamemaster");

            migrationBuilder.DropTable(
                name: "TM_工種マスタ_TM_ConstructionTypeMaster");

            migrationBuilder.DropTable(
                name: "TM_市町村マスタ_TM_MunicipalityMaster");

            migrationBuilder.DropTable(
                name: "TM_役職マスタ_TM_JobMaster");

            migrationBuilder.DropTable(
                name: "TM_得意先マスタ_CustomerMaster");

            migrationBuilder.DropTable(
                name: "TM_支給区分マスタ_TM_PaymentClassificationMaster");

            migrationBuilder.DropTable(
                name: "TM_明細戻り_TM_ItemReturn");

            migrationBuilder.DropTable(
                name: "TM_明細補助マスタ_TM_AuxiliaryItemMaster");

            migrationBuilder.DropTable(
                name: "TM_暦マスタ_TM_CalendarMaster");

            migrationBuilder.DropTable(
                name: "TM_歩掛補正マスタ_TM_WalkCorrectionMaster");

            migrationBuilder.DropTable(
                name: "TM_消費税_TM_ConsumptionTax");

            migrationBuilder.DropTable(
                name: "TM_特殊分類1マスタ_TM_ SpecialClassification1Master");

            migrationBuilder.DropTable(
                name: "TM_特殊分類2マスタ_TM_SpecialClassification2Master");

            migrationBuilder.DropTable(
                name: "TM_特記事項マスタ_TM_SpecialNoteMaster");

            migrationBuilder.DropTable(
                name: "TM_素材マスタ_TM_MaterialMaster");

            migrationBuilder.DropTable(
                name: "TM_素材分類ヘッダ_TM_MaterialClassificationHeader");

            migrationBuilder.DropTable(
                name: "TM_素材分類マスタ_TM_MaterialClassificationMaster");

            migrationBuilder.DropTable(
                name: "TM_経費ランクマスタ_TM_ExpenseRankMaster");

            migrationBuilder.DropTable(
                name: "TM_補助マスタ_TM_Auxiliary_SupportMaster");

            migrationBuilder.DropTable(
                name: "TM_資格マスタ_TM_QualificationMaster");

            migrationBuilder.DropTable(
                name: "TM_追加品目マスタ_TM_AdditionalMaterialMaster");

            migrationBuilder.DropTable(
                name: "TM_都道府県マスタ_PrefectureMaster");

            migrationBuilder.DropTable(
                name: "TM_都道府県マスタ_TM_ StateandProvinceMaster");

            migrationBuilder.DropTable(
                name: "TM_配線器具マスタ_TM_WiringFixtureMaster");

            migrationBuilder.DropTable(
                name: "TM_電工マスタ_TM_ElectricianMaster");

            migrationBuilder.DropTable(
                name: "TM_電線まとめマスタ_TM_WireSummaryMaster");

            migrationBuilder.DropTable(
                name: "TR_内訳明細データ_DetailedBreakdownData");

            migrationBuilder.DropTable(
                name: "TR_内訳複合データ_CompositeBreakdownData");

            migrationBuilder.DropTable(
                name: "TR_内訳集計データ_ItemizedSummaryData");

            migrationBuilder.DropTable(
                name: "TR_分類別複合データ_CategorywiseCompositeData");

            migrationBuilder.DropTable(
                name: "TR_分類別集計データ_TR_CategorywiseSummaryData");

            migrationBuilder.DropTable(
                name: "TR_工種明細データ_WorkTypeDetailData");

            migrationBuilder.DropTable(
                name: "TR_比較表データ_ComparisonTableData");

            migrationBuilder.DropTable(
                name: "TR_積算一覧データ_QuotationListData");

            migrationBuilder.DropTable(
                name: "TR_積算印刷データ_QuotationPrintData");

            migrationBuilder.DropTable(
                name: "TR_積算実行データ_QuotationExecutionData");

            migrationBuilder.DropTable(
                name: "TR_積算総括データ_QuotationSummaryData");

            migrationBuilder.DropTable(
                name: "TR_素材乗率データ_MaterialLoadingRateData");

            migrationBuilder.DropTable(
                name: "TR_複合単価データ_CompositeUnitPriceData");

            migrationBuilder.DropTable(
                name: "TR_複合印刷データ_CompositePrintData");

            migrationBuilder.DropTable(
                name: "TR_複合総括データ_CompositeSummaryData");

            migrationBuilder.DropTable(
                name: "TW_ファンクション_Function");

            migrationBuilder.DropTable(
                name: "TW_合成単価データ_CombinedUnitPriceData");

            migrationBuilder.DropTable(
                name: "TW_同一CD異単価チェック_SameCDDifferentUnitPriceCheck");

            migrationBuilder.DropTable(
                name: "TW_基礎データ_BasicData");

            migrationBuilder.DropTable(
                name: "TW_工種データ_ConstructionTypeData");

            migrationBuilder.DropTable(
                name: "TW_工種並替えワーク_WorkTypeReorderingWork");

            migrationBuilder.DropTable(
                name: "TW_引用部材乗率データ_ReferencedMaterialLoadingRateData");

            migrationBuilder.DropTable(
                name: "TW_明細分析データ_DetailAnalysisData");

            migrationBuilder.DropTable(
                name: "TW_検索素材マスタ_SearchMaterialMaster");

            migrationBuilder.DropTable(
                name: "TW_比較データ_ComparisonData");

            migrationBuilder.DropTable(
                name: "TW_比較基本データ_ComparisonBasicData");

            migrationBuilder.DropTable(
                name: "TW_積算集計データ_EstimationSummaryData");

            migrationBuilder.DropTable(
                name: "TW_総合複合単価ワーク_OverallCompositeUnitPriceWork");

            migrationBuilder.DropTable(
                name: "TW_製作所データ_ProducersData");

            migrationBuilder.DropTable(
                name: "TW_複合単価データ_CompositeUnitPriceData");

            migrationBuilder.DropTable(
                name: "TW_複合率設定データ_CompositeRateSettingData");

            migrationBuilder.DropTable(
                name: "TW_複合集計データ_CompositeAggregationData");

            migrationBuilder.DropTable(
                name: "TW_見積一覧ワーク_WorkQuotationSummary");

            migrationBuilder.DropTable(
                name: "TW_計算式_CalculationFormula");

            migrationBuilder.DropTable(
                name: "TW_追加並替えワーク_AdditionalReorderingWork");

            migrationBuilder.DropTable(
                name: "TW_部材データ_MaterialsData");

            migrationBuilder.DropTable(
                name: "TW_部材並替えワーク1_MaterialReorderingWork1");

            migrationBuilder.DropTable(
                name: "TW_部材並替えワーク2_MaterialReorderingWork2");

            migrationBuilder.DropTable(
                name: "TW_部署データ_DepartmentData");

            migrationBuilder.DropTable(
                name: "TW_集計工種選択_AggregationWorkTypeSelection");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
