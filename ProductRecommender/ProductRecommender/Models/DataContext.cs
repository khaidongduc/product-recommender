using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductRecommender.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Dim_AddressMapping> Dim_AddressMapping { get; set; }
        public virtual DbSet<Dim_Album> Dim_Album { get; set; }
        public virtual DbSet<Dim_AppUser> Dim_AppUser { get; set; }
        public virtual DbSet<Dim_AppUserMapping> Dim_AppUserMapping { get; set; }
        public virtual DbSet<Dim_Brand> Dim_Brand { get; set; }
        public virtual DbSet<Dim_BrandInStoreProductGroupingMapping> Dim_BrandInStoreProductGroupingMapping { get; set; }
        public virtual DbSet<Dim_Category> Dim_Category { get; set; }
        public virtual DbSet<Dim_Date> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMapping> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_DirectSalesOrderSourceType> Dim_DirectSalesOrderSourceType { get; set; }
        public virtual DbSet<Dim_District> Dim_District { get; set; }
        public virtual DbSet<Dim_ERouteType> Dim_ERouteType { get; set; }
        public virtual DbSet<Dim_EditedPriceStatus> Dim_EditedPriceStatus { get; set; }
        public virtual DbSet<Dim_ErpApprovalState> Dim_ErpApprovalState { get; set; }
        public virtual DbSet<Dim_GeneralApprovalState> Dim_GeneralApprovalState { get; set; }
        public virtual DbSet<Dim_Item> Dim_Item { get; set; }
        public virtual DbSet<Dim_ItemMapping> Dim_ItemMapping { get; set; }
        public virtual DbSet<Dim_KpiCriteriaGeneral> Dim_KpiCriteriaGeneral { get; set; }
        public virtual DbSet<Dim_KpiGeneral> Dim_KpiGeneral { get; set; }
        public virtual DbSet<Dim_Month> Dim_Month { get; set; }
        public virtual DbSet<Dim_Organization> Dim_Organization { get; set; }
        public virtual DbSet<Dim_POSMTransactionType> Dim_POSMTransactionType { get; set; }
        public virtual DbSet<Dim_ProblemStatus> Dim_ProblemStatus { get; set; }
        public virtual DbSet<Dim_ProblemType> Dim_ProblemType { get; set; }
        public virtual DbSet<Dim_Product> Dim_Product { get; set; }
        public virtual DbSet<Dim_ProductGrouping> Dim_ProductGrouping { get; set; }
        public virtual DbSet<Dim_ProductType> Dim_ProductType { get; set; }
        public virtual DbSet<Dim_Province> Dim_Province { get; set; }
        public virtual DbSet<Dim_Quarter> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_RequestState> Dim_RequestState { get; set; }
        public virtual DbSet<Dim_ShowingItem> Dim_ShowingItem { get; set; }
        public virtual DbSet<Dim_ShowingItemMapping> Dim_ShowingItemMapping { get; set; }
        public virtual DbSet<Dim_Status> Dim_Status { get; set; }
        public virtual DbSet<Dim_Store> Dim_Store { get; set; }
        public virtual DbSet<Dim_StoreApprovalState> Dim_StoreApprovalState { get; set; }
        public virtual DbSet<Dim_StoreCheckingStatus> Dim_StoreCheckingStatus { get; set; }
        public virtual DbSet<Dim_StoreGrouping> Dim_StoreGrouping { get; set; }
        public virtual DbSet<Dim_StoreMapping> Dim_StoreMapping { get; set; }
        public virtual DbSet<Dim_StoreScoutingStatus> Dim_StoreScoutingStatus { get; set; }
        public virtual DbSet<Dim_StoreScoutingType> Dim_StoreScoutingType { get; set; }
        public virtual DbSet<Dim_StoreStatus> Dim_StoreStatus { get; set; }
        public virtual DbSet<Dim_StoreStatusHistoryType> Dim_StoreStatusHistoryType { get; set; }
        public virtual DbSet<Dim_StoreType> Dim_StoreType { get; set; }
        public virtual DbSet<Dim_Supplier> Dim_Supplier { get; set; }
        public virtual DbSet<Dim_TaxType> Dim_TaxType { get; set; }
        public virtual DbSet<Dim_TransactionType> Dim_TransactionType { get; set; }
        public virtual DbSet<Dim_UnitOfMeasure> Dim_UnitOfMeasure { get; set; }
        public virtual DbSet<Dim_UsedVariation> Dim_UsedVariation { get; set; }
        public virtual DbSet<Dim_Ward> Dim_Ward { get; set; }
        public virtual DbSet<Dim_Warehouse> Dim_Warehouse { get; set; }
        public virtual DbSet<Dim_Year> Dim_Year { get; set; }
        public virtual DbSet<Fact_AppUserGps> Fact_AppUserGps { get; set; }
        public virtual DbSet<Fact_BrandHistory> Fact_BrandHistory { get; set; }
        public virtual DbSet<Fact_BrandInStore> Fact_BrandInStore { get; set; }
        public virtual DbSet<Fact_DirectSalesOrder> Fact_DirectSalesOrder { get; set; }
        public virtual DbSet<Fact_DirectSalesOrderTransaction> Fact_DirectSalesOrderTransaction { get; set; }
        public virtual DbSet<Fact_Image> Fact_Image { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrder> Fact_IndirectSalesOrder { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderTransaction> Fact_IndirectSalesOrderTransaction { get; set; }
        public virtual DbSet<Fact_Inventory> Fact_Inventory { get; set; }
        public virtual DbSet<Fact_KpiGeneralContent> Fact_KpiGeneralContent { get; set; }
        public virtual DbSet<Fact_POSMTransaction> Fact_POSMTransaction { get; set; }
        public virtual DbSet<Fact_Problem> Fact_Problem { get; set; }
        public virtual DbSet<Fact_ProductGroupingHistory> Fact_ProductGroupingHistory { get; set; }
        public virtual DbSet<Fact_StoreChecking> Fact_StoreChecking { get; set; }
        public virtual DbSet<Fact_StoreHistory> Fact_StoreHistory { get; set; }
        public virtual DbSet<Fact_StoreScouting> Fact_StoreScouting { get; set; }
        public virtual DbSet<Fact_StoreStatusHistory> Fact_StoreStatusHistory { get; set; }
        public virtual DbSet<Fact_StoreUnchecking> Fact_StoreUnchecking { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<View_KPIDoanhThu> View_KPIDoanhThu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=localhost;initial catalog=DW_DMS;persist security info=True;user id=sa;password=123@123a;multipleactiveresultsets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Dim_AddressMapping>(entity =>
            {
                entity.HasKey(e => e.AddressMappingId);
            });

            modelBuilder.Entity<Dim_Album>(entity =>
            {
                entity.HasKey(e => e.AlbumId);

                entity.Property(e => e.AlbumId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_AppUser>(entity =>
            {
                entity.HasKey(e => e.AppUserId);

                entity.Property(e => e.AppUserId)
                    .HasComment("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasComment("Địa chỉ nhà");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(4000)
                    .HasComment("Ảnh đại diện");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasComment("Ngày sinh");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày xoá");

                entity.Property(e => e.Department)
                    .HasMaxLength(500)
                    .HasComment("Phòng ban");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .HasComment("Tên hiển thị");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .HasComment("Địa chỉ email");

                entity.Property(e => e.OrganizationId).HasComment("Đơn vị công tác");

                entity.Property(e => e.Phone)
                    .HasMaxLength(500)
                    .HasComment("Số điện thoại liên hệ");

                entity.Property(e => e.RowId).HasComment("Trường để đồng bộ");

                entity.Property(e => e.StatusId).HasComment("Trạng thái");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày cập nhật");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("Tên đăng nhập");
            });

            modelBuilder.Entity<Dim_AppUserMapping>(entity =>
            {
                entity.HasKey(e => e.AppUserMappingId);
            });

            modelBuilder.Entity<Dim_Brand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandId)
                    .HasComment("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("Mã nhãn hiệu");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày xoá");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasComment("Mô tả");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("Tên nhãn nhiệu");

                entity.Property(e => e.StatusId).HasComment("Trạng thái hoạt động");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày cập nhật");
            });

            modelBuilder.Entity<Dim_BrandInStoreProductGroupingMapping>(entity =>
            {
                entity.HasKey(e => new { e.BrandInStoreId, e.ProductGroupingId })
                    .HasName("PK_BrandInStoreProductGroupingMapping");
            });

            modelBuilder.Entity<Dim_Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Date>(entity =>
            {
                entity.HasKey(e => e.DateId);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DayOfWeekName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_DateMapping>(entity =>
            {
                entity.HasKey(e => e.DateMappingId);

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_DirectSalesOrderSourceType>(entity =>
            {
                entity.HasKey(e => e.DirectSalesOrderSourceTypeId);

                entity.Property(e => e.DirectSalesOrderSourceTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_District>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.Property(e => e.DistrictId)
                    .HasComment("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(500)
                    .HasComment("Mã quận huyện");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày xoá");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("Tên quận huyện");

                entity.Property(e => e.Priority).HasComment("Thứ tự ưu tiên");

                entity.Property(e => e.ProvinceId).HasComment("Tỉnh phụ thuộc");

                entity.Property(e => e.RowId).HasComment("Trường để đồng bộ");

                entity.Property(e => e.StatusId).HasComment("Trạng thái hoạt động");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày cập nhật");
            });

            modelBuilder.Entity<Dim_ERouteType>(entity =>
            {
                entity.HasKey(e => e.ERouteTypeId);

                entity.Property(e => e.ERouteTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_EditedPriceStatus>(entity =>
            {
                entity.HasKey(e => e.EditedPriceStatusId);

                entity.Property(e => e.EditedPriceStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_ErpApprovalState>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_GeneralApprovalState>(entity =>
            {
                entity.HasKey(e => e.GeneralApprovalStateId);

                entity.Property(e => e.GeneralApprovalStateId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_Item>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.ERPCode).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Note).HasMaxLength(3000);

                entity.Property(e => e.OtherName).HasMaxLength(1000);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ScanCode).HasMaxLength(500);

                entity.Property(e => e.SupplierCode).HasMaxLength(500);

                entity.Property(e => e.TechnicalName).HasMaxLength(1000);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ItemMapping>(entity =>
            {
                entity.HasKey(e => e.ItemMappingId);
            });

            modelBuilder.Entity<Dim_KpiCriteriaGeneral>(entity =>
            {
                entity.HasKey(e => e.KpiCriteriaGeneralId);

                entity.Property(e => e.KpiCriteriaGeneralId).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_KpiGeneral>(entity =>
            {
                entity.HasKey(e => e.KpiGeneralId);

                entity.Property(e => e.KpiGeneralId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Month>(entity =>
            {
                entity.HasKey(e => e.MonthId);
            });

            modelBuilder.Entity<Dim_Organization>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.Property(e => e.OrganizationId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_POSMTransactionType>(entity =>
            {
                entity.HasKey(e => e.TransactionTypeId);

                entity.Property(e => e.TransactionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ProblemStatus>(entity =>
            {
                entity.HasKey(e => e.ProblemStatusId)
                    .HasName("PK_Dim_ProblemStatusEnum");

                entity.Property(e => e.ProblemStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ProblemType>(entity =>
            {
                entity.HasKey(e => e.ProblemTypeId);

                entity.Property(e => e.ProblemTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.ERPCode).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Note).HasMaxLength(3000);

                entity.Property(e => e.OtherName).HasMaxLength(1000);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ScanCode).HasMaxLength(500);

                entity.Property(e => e.SupplierCode).HasMaxLength(500);

                entity.Property(e => e.TechnicalName).HasMaxLength(1000);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ProductGrouping>(entity =>
            {
                entity.HasKey(e => e.ProductGroupingId);

                entity.Property(e => e.ProductGroupingId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.Property(e => e.ProductTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.Property(e => e.ProvinceId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Quarter>(entity =>
            {
                entity.HasKey(e => e.QuarterId);
            });

            modelBuilder.Entity<Dim_RequestState>(entity =>
            {
                entity.HasKey(e => e.RequestStateId);

                entity.Property(e => e.RequestStateId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_ShowingItem>(entity =>
            {
                entity.HasKey(e => e.ShowingItemId)
                    .HasName("PK_ShowingItem");

                entity.Property(e => e.ShowingItemId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ERPCode).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ShowingItemMapping>(entity =>
            {
                entity.HasKey(e => e.ShowingItemMappingId)
                    .HasName("PK_Dim_ShowingItemMapping_1");
            });

            modelBuilder.Entity<Dim_Status>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Store>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.Property(e => e.StoreId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(3000);

                entity.Property(e => e.Code).HasMaxLength(400);

                entity.Property(e => e.CodeDraft).HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(3000);

                entity.Property(e => e.DeliveryLatitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.DeliveryLongitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.LegalEntity).HasMaxLength(500);

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OwnerEmail).HasMaxLength(500);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OwnerPhone)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TaxCode).HasMaxLength(500);

                entity.Property(e => e.Telephone).HasMaxLength(500);

                entity.Property(e => e.UnsignAddress).HasMaxLength(3000);

                entity.Property(e => e.UnsignName).HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_StoreApprovalState>(entity =>
            {
                entity.HasKey(e => e.StoreApprovalStateId);

                entity.Property(e => e.StoreApprovalStateId).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_StoreCheckingStatus>(entity =>
            {
                entity.HasKey(e => e.StoreCheckingStatusId);

                entity.Property(e => e.StoreCheckingStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_StoreGrouping>(entity =>
            {
                entity.HasKey(e => e.StoreGroupingId);

                entity.Property(e => e.StoreGroupingId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_StoreMapping>(entity =>
            {
                entity.HasKey(e => e.StoreMappingId);
            });

            modelBuilder.Entity<Dim_StoreScoutingStatus>(entity =>
            {
                entity.HasKey(e => e.StoreScoutingStatusId);

                entity.Property(e => e.StoreScoutingStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_StoreScoutingType>(entity =>
            {
                entity.HasKey(e => e.StoreScoutingTypeId);

                entity.Property(e => e.StoreScoutingTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_StoreStatus>(entity =>
            {
                entity.HasKey(e => e.StoreStatusId);

                entity.Property(e => e.StoreStatusId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_StoreStatusHistoryType>(entity =>
            {
                entity.HasKey(e => e.StoreStatusHistoryTypeId);

                entity.Property(e => e.StoreStatusHistoryTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_StoreType>(entity =>
            {
                entity.HasKey(e => e.StoreTypeId);

                entity.Property(e => e.StoreTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.Property(e => e.SupplierId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OwnerName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.TaxCode).HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_TaxType>(entity =>
            {
                entity.HasKey(e => e.TaxTypeId);

                entity.Property(e => e.TaxTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_TransactionType>(entity =>
            {
                entity.HasKey(e => e.TransactionTypeId)
                    .HasName("PK_Dim_SaleType");

                entity.Property(e => e.TransactionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_UnitOfMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitOfMeasureId);

                entity.Property(e => e.UnitOfMeasureId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_UsedVariation>(entity =>
            {
                entity.HasKey(e => e.UsedVariationId);

                entity.Property(e => e.UsedVariationId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_Ward>(entity =>
            {
                entity.HasKey(e => e.WardId);

                entity.Property(e => e.WardId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Warehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.Property(e => e.WarehouseId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Year>(entity =>
            {
                entity.HasKey(e => e.YearId);
            });

            modelBuilder.Entity<Fact_AppUserGps>(entity =>
            {
                entity.HasKey(e => e.AppUserGpsId)
                    .HasName("PK_AppUserGps");

                entity.Property(e => e.GPSUpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 14)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 14)");
            });

            modelBuilder.Entity<Fact_BrandHistory>(entity =>
            {
                entity.HasKey(e => e.BrandHistoryId);

                entity.Property(e => e.BrandHistoryId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_BrandInStore>(entity =>
            {
                entity.HasKey(e => e.BrandInStoreId)
                    .HasName("PK_BrandInStore");

                entity.HasComment("Danh sách các thương hiệu trong 1 cửa hàng");

                entity.Property(e => e.BrandInStoreId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_DirectSalesOrder>(entity =>
            {
                entity.HasKey(e => e.DirectSalesOrderId)
                    .HasName("PK_Fact_DirectSalesOrder_1");

                entity.Property(e => e.DirectSalesOrderId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Mã đơn hàng");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày giao hàng");

                entity.Property(e => e.EditedPriceStatusId).HasComment("Sửa giá");

                entity.Property(e => e.GeneralDiscountAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Số tiền chiết khấu tổng");

                entity.Property(e => e.GeneralDiscountPercentage)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("% chiết khấu tổng");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PromotionCode).HasMaxLength(50);

                entity.Property(e => e.PromotionValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Tổng tiền trước thuế");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Tổng tiền sau thuế");

                entity.Property(e => e.TotalAfterTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Tổng thuế");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_DirectSalesOrderTransaction>(entity =>
            {
                entity.HasKey(e => new { e.DirectSalesOrderTransactionId, e.DirectSalesOrderId, e.TransactionTypeId })
                    .HasName("PK_Fact_DirectSalesOrderTransaction_1");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày giao hàng");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountPercentage).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequestedQuantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Giá bán theo đơn vị xuất hàng");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxPercentage).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Fact_Image>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.Property(e => e.ImageId).ValueGeneratedNever();

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.ShootingAt).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_IndirectSalesOrder>(entity =>
            {
                entity.HasKey(e => e.IndirectSalesOrderId);

                entity.Property(e => e.IndirectSalesOrderId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Mã đơn hàng");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày giao hàng");

                entity.Property(e => e.EditedPriceStatusId).HasComment("Sửa giá");

                entity.Property(e => e.GeneralDiscountAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Số tiền chiết khấu tổng");

                entity.Property(e => e.GeneralDiscountPercentage)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("% chiết khấu tổng");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Tổng tiền trước thuế");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Tổng tiền sau thuế");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_IndirectSalesOrderTransaction>(entity =>
            {
                entity.HasKey(e => new { e.IndirectSalesOrderTransactionId, e.IndirectSalesOrderId, e.TransactionTypeId });

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày giao hàng");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountPercentage).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequestStateId).HasComment("Ngày giao hàng");

                entity.Property(e => e.RequestedQuantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasComment("Giá bán theo đơn vị xuất hàng");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxPercentage).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Fact_Inventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK_Inventory");

                entity.Property(e => e.InventoryId).ValueGeneratedNever();

                entity.Property(e => e.AccountingStock).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SaleStock).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_KpiGeneralContent>(entity =>
            {
                entity.HasKey(e => e.KpiGeneralContentId);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_POSMTransaction>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_Problem>(entity =>
            {
                entity.HasKey(e => e.ProblemId);

                entity.Property(e => e.ProblemId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompletedAt).HasColumnType("datetime");

                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.NoteAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_ProductGroupingHistory>(entity =>
            {
                entity.HasKey(e => e.ProductGroupingHistoryId);

                entity.Property(e => e.ProductGroupingHistoryId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Fact_StoreChecking>(entity =>
            {
                entity.HasKey(e => e.StoreCheckingId);

                entity.Property(e => e.StoreCheckingId).ValueGeneratedNever();

                entity.Property(e => e.CheckInAt).HasColumnType("datetime");

                entity.Property(e => e.CheckOutAt).HasColumnType("datetime");

                entity.Property(e => e.CheckOutLatitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.CheckOutLongitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.DeviceName).HasMaxLength(200);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            });

            modelBuilder.Entity<Fact_StoreHistory>(entity =>
            {
                entity.HasKey(e => e.StoreHistoryId);

                entity.Property(e => e.StoreHistoryId).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(400);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Fact_StoreScouting>(entity =>
            {
                entity.HasKey(e => e.StoreScoutingId);

                entity.Property(e => e.StoreScoutingId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OwnerPhone).HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_StoreStatusHistory>(entity =>
            {
                entity.HasKey(e => e.StoreStatusHistoryId);

                entity.Property(e => e.StoreStatusHistoryId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PreviousCreatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_StoreUnchecking>(entity =>
            {
                entity.HasKey(e => e.StoreUncheckingId);

                entity.Property(e => e.StoreUncheckingId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<View_KPIDoanhThu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KPIDoanhThu");

                entity.Property(e => e.KPI)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 4)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
