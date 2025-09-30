using System;
using System.Collections.Generic;
using ePR_App_Api.Data;
using Microsoft.EntityFrameworkCore;

namespace ePR_App_Api.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<BaseUrl> BaseUrls { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<BudgetTransaction> BudgetTransactions { get; set; }

    public virtual DbSet<DocumentApproval> DocumentApprovals { get; set; }

    public virtual DbSet<DocumentAttachment> DocumentAttachments { get; set; }

    public virtual DbSet<DocumentChangeLog> DocumentChangeLogs { get; set; }

    public virtual DbSet<DocumentComment> DocumentComments { get; set; }

    public virtual DbSet<EmailSchedule> EmailSchedules { get; set; }

    public virtual DbSet<EmailSummaryDaily> EmailSummaryDailies { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<Evaluation> Evaluations { get; set; }

    public virtual DbSet<Grn> Grns { get; set; }

    public virtual DbSet<Grn1> Grn1s { get; set; }

    public virtual DbSet<HighRisk> HighRisks { get; set; }

    public virtual DbSet<ItemWh> ItemWhs { get; set; }

    public virtual DbSet<MaccountAssigment> MaccountAssigments { get; set; }

    public virtual DbSet<McostCenter> McostCenters { get; set; }

    public virtual DbSet<Mcurrency> Mcurrencies { get; set; }

    public virtual DbSet<Mdepartment> Mdepartments { get; set; }

    public virtual DbSet<Mdivision> Mdivisions { get; set; }

    public virtual DbSet<MdocType> MdocTypes { get; set; }

    public virtual DbSet<Mitem> Mitems { get; set; }

    public virtual DbSet<Mplant> Mplants { get; set; }

    public virtual DbSet<MpurOrg> MpurOrgs { get; set; }

    public virtual DbSet<MpurchaseGroup> MpurchaseGroups { get; set; }

    public virtual DbSet<Mslocation> Mslocations { get; set; }

    public virtual DbSet<Mtax> Mtaxes { get; set; }

    public virtual DbSet<Mterm> Mterms { get; set; }

    public virtual DbSet<MuoM> MuoMs { get; set; }

    public virtual DbSet<Mvendor> Mvendors { get; set; }

    public virtual DbSet<Pa> Pas { get; set; }

    public virtual DbSet<Pa1> Pa1s { get; set; }

    public virtual DbSet<Paapproval> Paapprovals { get; set; }

    public virtual DbSet<Pah> Pahs { get; set; }

    public virtual DbSet<PostingPeriod> PostingPeriods { get; set; }

    public virtual DbSet<PostingPeriod1> PostingPeriod1s { get; set; }

    public virtual DbSet<Pr> Prs { get; set; }

    public virtual DbSet<Pr1> Pr1s { get; set; }

    public virtual DbSet<Prapproval> Prapprovals { get; set; }

    public virtual DbSet<Prclarify> Prclarifies { get; set; }

    public virtual DbSet<Prhrt> Prhrts { get; set; }

    public virtual DbSet<Prhrtapproval> Prhrtapprovals { get; set; }

    public virtual DbSet<ProcurementRoute> ProcurementRoutes { get; set; }

    public virtual DbSet<Prstatus> Prstatuses { get; set; }

    public virtual DbSet<PrwaverApproval> PrwaverApprovals { get; set; }

    public virtual DbSet<Renewal> Renewals { get; set; }

    public virtual DbSet<Se> Ses { get; set; }

    public virtual DbSet<Ses1> Ses1s { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Supplier1> Supplier1s { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Table2> Table2s { get; set; }

    public virtual DbSet<Transferpermission> Transferpermissions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VBudget> VBudgets { get; set; }

    public virtual DbSet<VBudgetTransaction> VBudgetTransactions { get; set; }

    public virtual DbSet<VDelegation> VDelegations { get; set; }

    public virtual DbSet<VDep> VDeps { get; set; }

    public virtual DbSet<VDepartment> VDepartments { get; set; }

    public virtual DbSet<VDiv> VDivs { get; set; }

    public virtual DbSet<VDivision> VDivisions { get; set; }

    public virtual DbSet<VDocumentApproval> VDocumentApprovals { get; set; }

    public virtual DbSet<VDocumentAttachment> VDocumentAttachments { get; set; }

    public virtual DbSet<VDocumentChangeLog> VDocumentChangeLogs { get; set; }

    public virtual DbSet<VDocumentComment> VDocumentComments { get; set; }

    public virtual DbSet<VDocumentCommentSrso> VDocumentCommentSrsos { get; set; }

    public virtual DbSet<VGrndetail> VGrndetails { get; set; }

    public virtual DbSet<VPa> VPas { get; set; }

    public virtual DbSet<VPa1> VPa1s { get; set; }

    public virtual DbSet<VPaapproval> VPaapprovals { get; set; }

    public virtual DbSet<VPab> VPabs { get; set; }

    public virtual DbSet<VPr> VPrs { get; set; }

    public virtual DbSet<VPr1> VPr1s { get; set; }

    public virtual DbSet<VPr1Balance> VPr1Balances { get; set; }

    public virtual DbSet<VPrList> VPrLists { get; set; }

    public virtual DbSet<VPrapproval> VPrapprovals { get; set; }

    public virtual DbSet<VPrb> VPrbs { get; set; }

    public virtual DbSet<VPrhrtapproval> VPrhrtapprovals { get; set; }

    public virtual DbSet<VPrwavier> VPrwaviers { get; set; }

    public virtual DbSet<VSesDetail> VSesDetails { get; set; }

    public virtual DbSet<VSo> VSos { get; set; }

    public virtual DbSet<VSo1> VSo1s { get; set; }

    public virtual DbSet<VSoapproval> VSoapprovals { get; set; }

    public virtual DbSet<VSr> VSrs { get; set; }

    public virtual DbSet<VSr1> VSr1s { get; set; }

    public virtual DbSet<VSrapproval> VSrapprovals { get; set; }
    public virtual DbSet<PRItemList> App_Api_Get_PR_List { get; set; }
    public virtual DbSet<PAItemList> App_Api_Get_PA_List { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.AttchId);

            entity.ToTable("Attachment");

            entity.Property(e => e.AttchId).HasColumnName("AttchID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocType).HasMaxLength(50);
            entity.Property(e => e.F2).HasMaxLength(200);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.OriFileName).HasMaxLength(200);
            entity.Property(e => e.SaveFileName).HasMaxLength(250);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<BaseUrl>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("BaseURL");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Urllink)
                .HasMaxLength(100)
                .HasColumnName("URLLink");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.DocNum).HasName("PK__Budget__420AEAF184A904B5");

            entity.ToTable("Budget");

            entity.Property(e => e.AdditionalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ApplyAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Balance)
                .HasComputedColumnSql("((([InitAmount]+[AdditionalAmount])+[TransferAmount])-[ApplyAmount])", false)
                .HasColumnType("numeric(21, 2)");
            entity.Property(e => e.BudgetType).HasMaxLength(10);
            entity.Property(e => e.ContractDesc).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dep).HasMaxLength(50);
            entity.Property(e => e.Division).HasMaxLength(50);
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Dscription).HasMaxLength(100);
            entity.Property(e => e.InitAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.TransferAmount)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BudgetTransaction>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK_BudgetTransaction_1");

            entity.ToTable("BudgetTransaction");

            entity.Property(e => e.BlockBg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BlockBG");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromDocNum).HasMaxLength(20);
            entity.Property(e => e.RefStatus).HasMaxLength(20);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ToDocNum).HasMaxLength(20);
            entity.Property(e => e.TranAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TranType).HasMaxLength(10);
        });

        modelBuilder.Entity<DocumentApproval>(entity =>
        {
            entity.HasKey(e => e.DocEntry);

            entity.ToTable("DocumentApproval");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentAttachment>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK__Document__F4D96FAE72731722");

            entity.ToTable("DocumentAttachment");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentChangeLog>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK__Document__F4D96FAEA7AF40A6");

            entity.ToTable("DocumentChangeLog");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentComment>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK__Document__F4D96FAE2D8C2C6F");

            entity.ToTable("DocumentComment");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isClarify");
            entity.Property(e => e.ToUserCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<EmailSchedule>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK__Email_Sc__F4D96FAE86AA60B3");

            entity.ToTable("Email_Schedule");

            entity.Property(e => e.DocTime).HasMaxLength(20);
            entity.Property(e => e.DocType).HasMaxLength(10);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<EmailSummaryDaily>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK__Email_Su__F4D96FAE4251BC72");

            entity.ToTable("Email_Summary_Daily");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTime).HasMaxLength(20);
            entity.Property(e => e.DocType).HasMaxLength(10);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.TempType).HasName("PK__EmailTem__1FE9DECC34CA6C06");

            entity.ToTable("EmailTemplate");

            entity.Property(e => e.TempType).HasMaxLength(50);
            entity.Property(e => e.DocType).HasMaxLength(5);
            entity.Property(e => e.Htmltemplate).HasColumnName("HTMLTemplate");
            entity.Property(e => e.MailStatus).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(200);
        });

        modelBuilder.Entity<Evaluation>(entity =>
        {
            entity.HasKey(e => e.DocKey).HasName("PK_Evauation");

            entity.ToTable("Evaluation");

            entity.Property(e => e.DocKey).ValueGeneratedNever();
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.SupplierName).HasMaxLength(250);

            entity.HasOne(d => d.DocKeyNavigation).WithOne(p => p.Evaluation)
                .HasForeignKey<Evaluation>(d => d.DocKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evauation_Evauation");
        });

        modelBuilder.Entity<Grn>(entity =>
        {
            entity.HasKey(e => e.Grnnum).HasName("PK__GRN__E45BEF7E8E3D0DA1");

            entity.ToTable("GRN");

            entity.Property(e => e.Grnnum)
                .HasMaxLength(20)
                .HasColumnName("GRNNum");
            entity.Property(e => e.ApprovalUpdated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bill).HasMaxLength(100);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CancelState)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(35);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliverRef).HasMaxLength(50);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Ponum)
                .HasMaxLength(20)
                .HasColumnName("PONum");
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.Sapnum)
                .HasMaxLength(20)
                .HasColumnName("SAPNum");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Grn1>(entity =>
        {
            entity.HasKey(e => new { e.Grnnum, e.LineNum });

            entity.ToTable("GRN1");

            entity.Property(e => e.Grnnum)
                .HasMaxLength(20)
                .HasColumnName("GRNNum");
            entity.Property(e => e.BaseEntry).HasMaxLength(20);
            entity.Property(e => e.DocAction).HasMaxLength(10);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(15);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PlantCode).HasMaxLength(4);
            entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");
            entity.Property(e => e.Sloc)
                .HasMaxLength(4)
                .HasColumnName("SLoc");
            entity.Property(e => e.UoM).HasMaxLength(4);
            entity.Property(e => e.Uprice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("UPrice");

            entity.HasOne(d => d.GrnnumNavigation).WithMany(p => p.Grn1s)
                .HasForeignKey(d => d.Grnnum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRN1_GRN");
        });

        modelBuilder.Entity<HighRisk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HighRisk");

            entity.Property(e => e.Status).HasMaxLength(30);
        });

        modelBuilder.Entity<ItemWh>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Currency).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.MaterialGroup).HasMaxLength(20);
            entity.Property(e => e.MaterialType).HasMaxLength(20);
            entity.Property(e => e.PlantCode).HasMaxLength(20);
            entity.Property(e => e.UoM).HasMaxLength(10);
            entity.Property(e => e.Uprice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("UPrice");
        });

        modelBuilder.Entity<MaccountAssigment>(entity =>
        {
            entity.HasKey(e => e.AcctCode).HasName("PK__MAccount__21B5C07F93D878E7");

            entity.ToTable("MAccountAssigment");

            entity.Property(e => e.AcctCode).HasMaxLength(10);
            entity.Property(e => e.AcctName).HasMaxLength(100);
            entity.Property(e => e.AcctStatus).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<McostCenter>(entity =>
        {
            entity.HasKey(e => e.CostCode).HasName("PK__MCostCen__624072372472891F");

            entity.ToTable("MCostCenter");

            entity.Property(e => e.CostCode).HasMaxLength(10);
            entity.Property(e => e.CostName).HasMaxLength(20);
            entity.Property(e => e.CostStatus).HasMaxLength(15);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mcurrency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MCurrency");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurCode).HasMaxLength(5);
            entity.Property(e => e.CurName).HasMaxLength(50);
            entity.Property(e => e.CurStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<Mdepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MDepartment");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepCode).HasMaxLength(20);
            entity.Property(e => e.DepName).HasMaxLength(100);
            entity.Property(e => e.DepStatus).HasMaxLength(10);
            entity.Property(e => e.OldDepCode).HasMaxLength(20);
        });

        modelBuilder.Entity<Mdivision>(entity =>
        {
            entity.HasKey(e => e.DivCode).HasName("PK__MDivisio__80E653AAEDCD0592");

            entity.ToTable("MDivision");

            entity.Property(e => e.DivCode).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DivName).HasMaxLength(100);
            entity.Property(e => e.DivStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<MdocType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MDocType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocCode).HasMaxLength(10);
            entity.Property(e => e.DocName).HasMaxLength(100);
            entity.Property(e => e.DocStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<Mitem>(entity =>
        {
            entity.HasKey(e => e.ItemCode).HasName("PK__MItem__3ECC0FEB2D57A3D5");

            entity.ToTable("MItem");

            entity.Property(e => e.ItemCode).HasMaxLength(18);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DefUoM).HasMaxLength(3);
            entity.Property(e => e.IsItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCur).HasMaxLength(5);
            entity.Property(e => e.ItemGroup).HasMaxLength(9);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemStatus).HasMaxLength(10);
            entity.Property(e => e.ItemType).HasMaxLength(10);
            entity.Property(e => e.MaterialType).HasMaxLength(20);
            entity.Property(e => e.PlantCode).HasMaxLength(10);
            entity.Property(e => e.PolongText)
                .HasMaxLength(500)
                .HasColumnName("POLongText");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mplant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MPlant");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PlantCode).HasMaxLength(10);
            entity.Property(e => e.PlantName).HasMaxLength(100);
            entity.Property(e => e.PlantStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<MpurOrg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MPurOrg");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PurOrgCode).HasMaxLength(10);
            entity.Property(e => e.PurOrgName).HasMaxLength(100);
            entity.Property(e => e.PurStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<MpurchaseGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MPurchaseGroup");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PurGroupName).HasMaxLength(100);
            entity.Property(e => e.PurGroupStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<Mslocation>(entity =>
        {
            entity.HasKey(e => e.SlocCode).HasName("PK__MSlocati__D74C2A6A63D0921C");

            entity.ToTable("MSLocation");

            entity.Property(e => e.SlocCode)
                .HasMaxLength(4)
                .HasColumnName("SLocCode");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PlantCode).HasMaxLength(4);
            entity.Property(e => e.SlocName)
                .HasMaxLength(16)
                .HasColumnName("SLocName");
            entity.Property(e => e.SlocStatus)
                .HasMaxLength(15)
                .HasColumnName("SLocStatus");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mtax>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MTax");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxCode).HasMaxLength(10);
            entity.Property(e => e.TaxName).HasMaxLength(100);
            entity.Property(e => e.TaxStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<Mterm>(entity =>
        {
            entity.HasKey(e => e.TermCode);

            entity.ToTable("MTerm");

            entity.Property(e => e.TermCode).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TermName).HasMaxLength(100);
            entity.Property(e => e.TermStatus).HasMaxLength(10);
        });

        modelBuilder.Entity<MuoM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MUoM");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OldUoMcode)
                .HasMaxLength(20)
                .HasColumnName("OldUoMCode");
            entity.Property(e => e.UoMcode)
                .HasMaxLength(20)
                .HasColumnName("UoMCode");
            entity.Property(e => e.UoMname)
                .HasMaxLength(100)
                .HasColumnName("UoMName");
            entity.Property(e => e.UoMstatus)
                .HasMaxLength(10)
                .HasColumnName("UoMStatus");
        });

        modelBuilder.Entity<Mvendor>(entity =>
        {
            entity.HasKey(e => e.VendorCode).HasName("PK__MVendor__3D531706109BA7C1");

            entity.ToTable("MVendor");

            entity.Property(e => e.VendorCode).HasMaxLength(10);
            entity.Property(e => e.AddressEn)
                .HasMaxLength(200)
                .HasColumnName("AddressEN");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sapjson).HasColumnName("SAPJson");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vattin)
                .HasMaxLength(20)
                .HasColumnName("VATTIN");
            entity.Property(e => e.VendorName1).HasMaxLength(100);
            entity.Property(e => e.VendorName2).HasMaxLength(100);
            entity.Property(e => e.VendorStatus).HasMaxLength(15);
        });

        modelBuilder.Entity<Pa>(entity =>
        {
            entity.HasKey(e => e.Panum).HasName("PK__PA__2CA79ACBBE5D9A4B");

            entity.ToTable("PA");

            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.AccountAssignment).HasMaxLength(5);
            entity.Property(e => e.AfterDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AppBy).HasMaxLength(50);
            entity.Property(e => e.AppDate).HasColumnType("datetime");
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.CardVatTin).HasMaxLength(50);
            entity.Property(e => e.CompanyCode).HasMaxLength(4);
            entity.Property(e => e.CostAvoidance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CostReduction).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryTime).HasMaxLength(50);
            entity.Property(e => e.Dep).HasMaxLength(100);
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.DocAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal)
                .HasComputedColumnSql("([AfterDiscount]+isnull([TaxAmount],(0)))", false)
                .HasColumnType("numeric(19, 2)");
            entity.Property(e => e.DocType).HasMaxLength(4);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderText).HasMaxLength(50);
            entity.Property(e => e.Incoterms).HasMaxLength(3);
            entity.Property(e => e.IncotermsLocation).HasMaxLength(70);
            entity.Property(e => e.IntDate).HasColumnType("datetime");
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsContract).HasMaxLength(100);
            entity.Property(e => e.IsLegal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsSapupdated)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("IsSAPUpdated");
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MailStatus).HasMaxLength(20);
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Padescription)
                .HasMaxLength(100)
                .HasColumnName("PADescription");
            entity.Property(e => e.PadescriptionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PADescriptionStatus");
            entity.Property(e => e.Patype)
                .HasMaxLength(3)
                .HasComment("NON,BOQ")
                .HasColumnName("PAType");
            entity.Property(e => e.Podate)
                .HasColumnType("datetime")
                .HasColumnName("PODate");
            entity.Property(e => e.Ponum)
                .HasMaxLength(50)
                .HasColumnName("PONum");
            entity.Property(e => e.Prdate)
                .HasMaxLength(20)
                .HasColumnName("PRDate");
            entity.Property(e => e.PrkeyList)
                .HasMaxLength(50)
                .HasColumnName("PRKeyList");
            entity.Property(e => e.Prnum)
                .HasMaxLength(100)
                .HasColumnName("PRNum");
            entity.Property(e => e.PurGroup).HasMaxLength(3);
            entity.Property(e => e.PurOrg).HasMaxLength(4);
            entity.Property(e => e.RejBy).HasMaxLength(50);
            entity.Property(e => e.RejDate).HasColumnType("datetime");
            entity.Property(e => e.RejectReason).HasMaxLength(300);
            entity.Property(e => e.ReleaseGroup).HasMaxLength(50);
            entity.Property(e => e.ReleaseIndicator).HasMaxLength(20);
            entity.Property(e => e.ReleaseStrategy).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Sapjson).HasColumnName("SAPJson");
            entity.Property(e => e.SapupdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("SAPUpdatedDate");
            entity.Property(e => e.SdocStatus)
                .HasMaxLength(20)
                .HasColumnName("SDocStatus");
            entity.Property(e => e.SubCom1).HasMaxLength(50);
            entity.Property(e => e.SubCom2).HasMaxLength(50);
            entity.Property(e => e.SubCom3).HasMaxLength(50);
            entity.Property(e => e.SubCom4).HasMaxLength(50);
            entity.Property(e => e.SubCom5).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Sup1).HasMaxLength(150);
            entity.Property(e => e.Sup2).HasMaxLength(150);
            entity.Property(e => e.Sup3).HasMaxLength(150);
            entity.Property(e => e.Sup4).HasMaxLength(150);
            entity.Property(e => e.Sup5).HasMaxLength(150);
            entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TaxGroup).HasMaxLength(10);
            entity.Property(e => e.TermCode).HasMaxLength(4);
            entity.Property(e => e.TermCondition).HasMaxLength(132);
            entity.Property(e => e.TermPayment).HasMaxLength(132);
            entity.Property(e => e.TermRemark).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Pa1>(entity =>
        {
            entity.HasKey(e => new { e.Panum, e.LineNum });

            entity.ToTable("PA1");

            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.AcctAssignment).HasMaxLength(1);
            entity.Property(e => e.ApplyQty).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.BalanceQty)
                .HasComputedColumnSql("([MQTY]-[ApplyQty])", false)
                .HasColumnType("numeric(19, 4)");
            entity.Property(e => e.BaseEntry).HasMaxLength(50);
            entity.Property(e => e.BaseType).HasMaxLength(20);
            entity.Property(e => e.CostCode).HasMaxLength(10);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.HeaderText).HasMaxLength(40);
            entity.Property(e => e.ItemCategory).HasMaxLength(1);
            entity.Property(e => e.ItemCode).HasMaxLength(18);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.ItemText).HasMaxLength(100);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MaterialGroup).HasMaxLength(50);
            entity.Property(e => e.MaterialPotext)
                .HasMaxLength(100)
                .HasColumnName("MaterialPOText");
            entity.Property(e => e.MgrossPrice)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MGrossPrice");
            entity.Property(e => e.Mqty)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MQTY");
            entity.Property(e => e.MuoM)
                .HasMaxLength(4)
                .HasColumnName("MUoM");
            entity.Property(e => e.NetPrice).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.PlantCode).HasMaxLength(4);
            entity.Property(e => e.RecordPotext)
                .HasMaxLength(100)
                .HasColumnName("RecordPOText");
            entity.Property(e => e.ServiceCode).HasMaxLength(18);
            entity.Property(e => e.ServiceName).HasMaxLength(200);
            entity.Property(e => e.ServicePercentage)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SgrossPrice)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SGrossPrice");
            entity.Property(e => e.SlocCode)
                .HasMaxLength(4)
                .HasColumnName("SLocCode");
            entity.Property(e => e.Sqty)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SQTY");
            entity.Property(e => e.SuoM)
                .HasMaxLength(3)
                .HasColumnName("SUoM");
            entity.Property(e => e.TaxCode).HasMaxLength(2);
            entity.Property(e => e.Uprice)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("UPrice");

            entity.HasOne(d => d.PanumNavigation).WithMany(p => p.Pa1s)
                .HasForeignKey(d => d.Panum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PA1__PANum__403A8C7D");
        });

        modelBuilder.Entity<Paapproval>(entity =>
        {
            entity.HasKey(e => new { e.Panum, e.UserId }).HasName("PK_PAApproval_1");

            entity.ToTable("PAApproval");

            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocEntry).ValueGeneratedOnAdd();
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Pah>(entity =>
        {
            entity.HasKey(e => new { e.Panum, e.LineNum });

            entity.ToTable("PAH");

            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetValue).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Prnum)
                .HasMaxLength(50)
                .HasColumnName("PRNum");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("QTY");
            entity.Property(e => e.UoM).HasMaxLength(5);
            entity.Property(e => e.Uprice).HasColumnType("numeric(18, 5)");

            entity.HasOne(d => d.PanumNavigation).WithMany(p => p.Pahs)
                .HasForeignKey(d => d.Panum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PAH__PANum__4222D4EF");
        });

        modelBuilder.Entity<PostingPeriod>(entity =>
        {
            entity.HasKey(e => e.Pyear).HasName("PK__PostingP__09B4629F56580DF0");

            entity.ToTable("PostingPeriod");

            entity.Property(e => e.Pyear)
                .ValueGeneratedNever()
                .HasColumnName("PYear");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
        });

        modelBuilder.Entity<PostingPeriod1>(entity =>
        {
            entity.HasKey(e => new { e.Pyear, e.Pmonth });

            entity.ToTable("PostingPeriod1");

            entity.Property(e => e.Pyear).HasColumnName("PYear");
            entity.Property(e => e.Pmonth)
                .HasMaxLength(5)
                .HasColumnName("PMonth");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.PyearNavigation).WithMany(p => p.PostingPeriod1s)
                .HasForeignKey(d => d.Pyear)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostingPe__PYear__60C757A0");
        });

        modelBuilder.Entity<Pr>(entity =>
        {
            entity.HasKey(e => e.DocKey).HasName("PK_PR_1");

            entity.ToTable("PR");

            entity.Property(e => e.ApprvedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprvedDate2).HasColumnType("datetime");
            entity.Property(e => e.ApprvedUser).HasMaxLength(30);
            entity.Property(e => e.ApprvedUser2).HasMaxLength(30);
            entity.Property(e => e.AtchDoc).HasMaxLength(200);
            entity.Property(e => e.AutoCancel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BlockPa)
                .HasMaxLength(1)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("BlockPA");
            entity.Property(e => e.Bpcode)
                .HasMaxLength(30)
                .HasColumnName("BPCode");
            entity.Property(e => e.Bpname)
                .HasMaxLength(100)
                .HasColumnName("BPName");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(30);
            entity.Property(e => e.Cancelreason).HasColumnName("cancelreason");
            entity.Property(e => e.CapexOpex).HasMaxLength(50);
            entity.Property(e => e.Clarifyuser)
                .HasMaxLength(50)
                .HasColumnName("clarifyuser");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(30);
            entity.Property(e => e.Dep).HasMaxLength(100);
            entity.Property(e => e.Direct)
                .HasMaxLength(50)
                .HasColumnName("direct");
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.DocAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(30);
            entity.Property(e => e.DocTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.HighRisk).HasDefaultValue(0);
            entity.Property(e => e.Hrt1).HasColumnName("HRT1");
            entity.Property(e => e.Hrt2).HasColumnName("HRT2");
            entity.Property(e => e.Hrt3).HasColumnName("HRT3");
            entity.Property(e => e.Hrt4).HasColumnName("HRT4");
            entity.Property(e => e.Hrt5).HasColumnName("HRT5");
            entity.Property(e => e.HrtmailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HRTMailStatus");
            entity.Property(e => e.IsCoi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("IsCOI");
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MailCashAdvance)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MailStatus).HasMaxLength(20);
            entity.Property(e => e.Nextapprover)
                .HasMaxLength(100)
                .HasColumnName("nextapprover");
            entity.Property(e => e.Pastatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAStatus");
            entity.Property(e => e.Prcolor).HasColumnName("PRColor");
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.RejectUser).HasMaxLength(30);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.Sapnum).HasColumnName("SAPNum");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ToEmail).HasMaxLength(100);
            entity.Property(e => e.UApproBudget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_ApproBudget");
            entity.Property(e => e.UDepartment)
                .HasMaxLength(50)
                .HasColumnName("U_Department");
            entity.Property(e => e.UDivision)
                .HasMaxLength(50)
                .HasColumnName("U_Division");
            entity.Property(e => e.UDocType)
                .HasMaxLength(50)
                .HasColumnName("U_DocType");
            entity.Property(e => e.UFrmCtctRef)
                .HasMaxLength(100)
                .HasColumnName("U_FrmCtctRef");
            entity.Property(e => e.UIntegraCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_IntegraCode");
            entity.Property(e => e.UNameofSupp)
                .HasMaxLength(100)
                .HasColumnName("U_NameofSupp");
            entity.Property(e => e.UPhone)
                .HasMaxLength(50)
                .HasColumnName("U_Phone");
            entity.Property(e => e.UPurProcedure)
                .HasMaxLength(50)
                .HasColumnName("U_PurProcedure");
            entity.Property(e => e.UPurType)
                .HasMaxLength(50)
                .HasColumnName("U_PurType");
            entity.Property(e => e.URemarks).HasColumnName("U_Remarks");
            entity.Property(e => e.USupplier1)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier1");
            entity.Property(e => e.USupplier2)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier2");
            entity.Property(e => e.USupplier3)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier3");
            entity.Property(e => e.USupplier4)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier4");
            entity.Property(e => e.USupplier5)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier5");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(30);
        });

        modelBuilder.Entity<Pr1>(entity =>
        {
            entity.HasKey(e => new { e.DocKey, e.LineId });

            entity.ToTable("PR1");

            entity.Property(e => e.AmountAfDis).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.BarCode).HasMaxLength(30);
            entity.Property(e => e.Bomcode)
                .HasMaxLength(30)
                .HasColumnName("BOMCode");
            entity.Property(e => e.DisPercent).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(30);
            entity.Property(e => e.ItemName).HasMaxLength(300);
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.PrexpenseType)
                .HasMaxLength(30)
                .HasColumnName("PRExpenseType");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Section).HasMaxLength(30);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UoM).HasMaxLength(30);
            entity.Property(e => e.VatCode).HasMaxLength(30);
            entity.Property(e => e.WhsCode).HasMaxLength(30);
        });

        modelBuilder.Entity<Prapproval>(entity =>
        {
            entity.HasKey(e => new { e.DocKey, e.UserId });

            entity.ToTable("PRApproval");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Prclarify>(entity =>
        {
            entity.HasKey(e => e.DocEntry).HasName("PK_PRClarify_1");

            entity.ToTable("PRClarify");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus).HasMaxLength(5);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");

            
        });

        modelBuilder.Entity<Prhrt>(entity =>
        {
            entity.HasKey(e => e.DocKey);

            entity.ToTable("PRHRT");

            entity.Property(e => e.DocKey).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Evalue)
                .HasMaxLength(500)
                .HasColumnName("EValue");
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Period).HasMaxLength(500);
            entity.Property(e => e.Scope).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(500);

            entity.HasOne(d => d.DocKeyNavigation).WithOne(p => p.Prhrt)
                .HasForeignKey<Prhrt>(d => d.DocKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRHRT_PRHRT");
        });

        modelBuilder.Entity<Prhrtapproval>(entity =>
        {
            entity.HasKey(e => new { e.DocKey, e.UserId });

            entity.ToTable("PRHRTApproval");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProcurementRoute>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Procurem__A25C5AA6C8A32EBE");

            entity.ToTable("ProcurementRoute");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Names).HasMaxLength(100);
        });

        modelBuilder.Entity<Prstatus>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__PRStatus__A25C5AA670909A1D");

            entity.ToTable("PRStatus");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Dscription).HasMaxLength(50);
        });

        modelBuilder.Entity<PrwaverApproval>(entity =>
        {
            entity.HasKey(e => new { e.DocKey, e.UserId });

            entity.ToTable("PRWaverApproval");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
        });

        modelBuilder.Entity<Renewal>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Renewal__A25C5AA6B7CC5C60");

            entity.ToTable("Renewal");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Dscription).HasMaxLength(100);
        });

        modelBuilder.Entity<Se>(entity =>
        {
            entity.HasKey(e => e.Sesnum).HasName("PK__SES__71D1D5BFE7DE36E0");

            entity.ToTable("SES");

            entity.Property(e => e.Sesnum)
                .HasMaxLength(20)
                .HasColumnName("SESNum");
            entity.Property(e => e.ApprovalUpdated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CancelState)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardNam).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.ExternalNum).HasMaxLength(50);
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Ponum)
                .HasMaxLength(20)
                .HasColumnName("PONum");
            entity.Property(e => e.Reason).HasMaxLength(300);
            entity.Property(e => e.Ref).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.Sapnum)
                .HasMaxLength(20)
                .HasColumnName("SAPNum");
            entity.Property(e => e.ServiceLocation).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Ses1>(entity =>
        {
            entity.HasKey(e => new { e.Sesnum, e.LineNum });

            entity.ToTable("SES1");

            entity.Property(e => e.Sesnum)
                .HasMaxLength(20)
                .HasColumnName("SESNum");
            entity.Property(e => e.BaseEntry).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(20);
            entity.Property(e => e.CancelState)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.Cancelleddate).HasColumnType("datetime");
            entity.Property(e => e.DocAction).HasMaxLength(15);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(15);
            entity.Property(e => e.Integration)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsUpdate)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("isUpdate");
            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.ItemName).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(100);
            entity.Property(e => e.LineAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LongText).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("QTY");
            entity.Property(e => e.Reason).HasMaxLength(300);
            entity.Property(e => e.Reference).HasMaxLength(16);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.Sapnum)
                .HasMaxLength(50)
                .HasColumnName("SAPNum");
            entity.Property(e => e.Term).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UoM).HasMaxLength(20);

            entity.HasOne(d => d.SesnumNavigation).WithMany(p => p.Ses1s)
                .HasForeignKey(d => d.Sesnum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SES1_SES");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupCode);

            entity.ToTable("Supplier");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.AllowSr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AllowSR");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SupName).HasMaxLength(200);
            entity.Property(e => e.Vattin)
                .HasMaxLength(50)
                .HasColumnName("VATTIN");
        });

        modelBuilder.Entity<Supplier1>(entity =>
        {
            entity.HasKey(e => new { e.SupCode, e.LineNum });

            entity.ToTable("Supplier1");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.FrameDescription).HasMaxLength(200);
            entity.Property(e => e.FrameNo).HasMaxLength(200);
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_1");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Table2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_2");

            entity.Property(e => e.Scode)
                .HasMaxLength(50)
                .HasColumnName("SCode");
            entity.Property(e => e.Sgroup)
                .HasMaxLength(50)
                .HasColumnName("SGroup");
            entity.Property(e => e.Uom).HasMaxLength(50);
        });

        modelBuilder.Entity<Transferpermission>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("transferpermission");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fromdate).HasColumnType("datetime");
            entity.Property(e => e.Fromuser).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.ToStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Todate).HasColumnType("datetime");
            entity.Property(e => e.Touser).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullGrn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FullGRN");
            entity.Property(e => e.FullPa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FullPA");
            entity.Property(e => e.FullPr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FullPR");
            entity.Property(e => e.FullSes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FullSES");
            entity.Property(e => e.Inactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Inv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INV");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ManagerId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.NextChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Password).HasMaxLength(300);
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.StandBy).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserGroup).HasMaxLength(100);
            entity.Property(e=>e.DeviceID).HasMaxLength(500);
        });

        modelBuilder.Entity<VBudget>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Budget");

            entity.Property(e => e.AdditionalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ApplyAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Balance).HasColumnType("numeric(21, 2)");
            entity.Property(e => e.BudgetType).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dep).HasMaxLength(50);
            entity.Property(e => e.Division).HasMaxLength(50);
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.DocNum).ValueGeneratedOnAdd();
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Dscription).HasMaxLength(100);
            entity.Property(e => e.InitAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.TransferAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VBudgetTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Budget_Transaction");

            entity.Property(e => e.AdditionalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ApplyAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Balance).HasColumnType("numeric(21, 2)");
            entity.Property(e => e.BudgetType).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Dscription).HasMaxLength(100);
            entity.Property(e => e.InitAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Memo).HasMaxLength(229);
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.ToDocNum).HasMaxLength(20);
            entity.Property(e => e.TranAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TranType).HasMaxLength(10);
            entity.Property(e => e.TransferAmount).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<VDelegation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Delegation");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Fromuser)
                .HasMaxLength(50)
                .HasColumnName("fromuser");
            entity.Property(e => e.Fromusername)
                .HasMaxLength(150)
                .HasColumnName("fromusername");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Touser)
                .HasMaxLength(50)
                .HasColumnName("touser");
            entity.Property(e => e.Tousername)
                .HasMaxLength(150)
                .HasColumnName("tousername");
        });

        modelBuilder.Entity<VDep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dep");

            entity.Property(e => e.DepCode).HasMaxLength(50);
            entity.Property(e => e.DepName).HasMaxLength(50);
            entity.Property(e => e.DivCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Department");

            entity.Property(e => e.DepId)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("DepID");
            entity.Property(e => e.DepName)
                .HasMaxLength(254)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<VDiv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Div");

            entity.Property(e => e.DivCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VDivision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Division");

            entity.Property(e => e.DivId)
                .HasMaxLength(20)
                .HasColumnName("DivID");
            entity.Property(e => e.DivName).HasMaxLength(100);
        });

        modelBuilder.Entity<VDocumentApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentApproval");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VDocumentAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentAttachment");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileLoc).HasMaxLength(200);
            entity.Property(e => e.FullFileName).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VDocumentChangeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentChangeLog");

            entity.Property(e => e.BaseDocNum).HasMaxLength(30);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VDocumentComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentComment");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isClarify");
            entity.Property(e => e.ToUserCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VDocumentCommentSrso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentCommentSRSO");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(5);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isClarify");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ToUserCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VGrndetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_GRNDetail");

            entity.Property(e => e.ApprovalUpdated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BaseEntry).HasMaxLength(20);
            entity.Property(e => e.Bill).HasMaxLength(100);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(35);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliverRef).HasMaxLength(50);
            entity.Property(e => e.DocAction).HasMaxLength(10);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Grnnum)
                .HasMaxLength(20)
                .HasColumnName("GRNNum");
            entity.Property(e => e.HighRiskDes).HasMaxLength(50);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LineStatus).HasMaxLength(15);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.PlantCode).HasMaxLength(4);
            entity.Property(e => e.Ponum)
                .HasMaxLength(20)
                .HasColumnName("PONum");
            entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.Sapnum)
                .HasMaxLength(20)
                .HasColumnName("SAPNum");
            entity.Property(e => e.Sloc)
                .HasMaxLength(4)
                .HasColumnName("SLoc");
            entity.Property(e => e.UoM).HasMaxLength(3);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Uprice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("UPrice");
        });

        modelBuilder.Entity<VPa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PA");

            entity.Property(e => e.AccountAssignment).HasMaxLength(5);
            entity.Property(e => e.AfterDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AppDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveStatus).HasMaxLength(170);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelName).HasMaxLength(150);
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.CardPhone)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CardVatTin).HasMaxLength(50);
            entity.Property(e => e.CompanyCode).HasMaxLength(4);
            entity.Property(e => e.CostAvoidance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CostReduction).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryTime).HasMaxLength(50);
            entity.Property(e => e.Dep).HasMaxLength(100);
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 2)");
            entity.Property(e => e.DocType).HasMaxLength(4);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderText).HasMaxLength(50);
            entity.Property(e => e.Incoterms).HasMaxLength(3);
            entity.Property(e => e.IncotermsLocation).HasMaxLength(70);
            entity.Property(e => e.IntDate).HasColumnType("datetime");
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsContract).HasMaxLength(100);
            entity.Property(e => e.IsLegal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.NextApproverName).HasMaxLength(150);
            entity.Property(e => e.PacreatorName)
                .HasMaxLength(150)
                .HasColumnName("PACreatorName");
            entity.Property(e => e.Padescription)
                .HasMaxLength(100)
                .HasColumnName("PADescription");
            entity.Property(e => e.PadescriptionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PADescriptionStatus");
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Patype)
                .HasMaxLength(3)
                .HasColumnName("PAType");
            entity.Property(e => e.Ponum)
                .HasMaxLength(53)
                .HasColumnName("PONum");
            entity.Property(e => e.Prdate)
                .HasMaxLength(20)
                .HasColumnName("PRDate");
            entity.Property(e => e.PrkeyList)
                .HasMaxLength(50)
                .HasColumnName("PRKeyList");
            entity.Property(e => e.Prnum)
                .HasMaxLength(100)
                .HasColumnName("PRNum");
            entity.Property(e => e.PurGroup).HasMaxLength(3);
            entity.Property(e => e.PurOrg).HasMaxLength(4);
            entity.Property(e => e.ReleaseGroup).HasMaxLength(50);
            entity.Property(e => e.ReleaseIndicator).HasMaxLength(20);
            entity.Property(e => e.ReleaseStrategy).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Rownum).HasColumnName("rownum");
            entity.Property(e => e.SdocStatus)
                .HasMaxLength(20)
                .HasColumnName("SDocStatus");
            entity.Property(e => e.SubCom1).HasMaxLength(50);
            entity.Property(e => e.SubCom2).HasMaxLength(50);
            entity.Property(e => e.SubCom3).HasMaxLength(50);
            entity.Property(e => e.SubCom4).HasMaxLength(50);
            entity.Property(e => e.SubCom5).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Sup1).HasMaxLength(150);
            entity.Property(e => e.Sup2).HasMaxLength(150);
            entity.Property(e => e.Sup3).HasMaxLength(150);
            entity.Property(e => e.Sup4).HasMaxLength(150);
            entity.Property(e => e.Sup5).HasMaxLength(150);
            entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TaxGroup).HasMaxLength(10);
            entity.Property(e => e.TermCode).HasMaxLength(4);
            entity.Property(e => e.TermCondition).HasMaxLength(132);
            entity.Property(e => e.TermPayment).HasMaxLength(132);
            entity.Property(e => e.TermRemark).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Not_Title).HasColumnName("Not_Title");
            entity.Property(e => e.Not_Body).HasColumnName("Not_Body");
        });

        modelBuilder.Entity<VPa1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PA1");

            entity.Property(e => e.AccountAssignment).HasMaxLength(5);
            entity.Property(e => e.AcctAssignment).HasMaxLength(1);
            entity.Property(e => e.AfterDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ApplyQty).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.BalanceQty).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.BaseEntry).HasMaxLength(50);
            entity.Property(e => e.BaseType).HasMaxLength(20);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.CardPhone)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CardVatTin).HasMaxLength(50);
            entity.Property(e => e.CompanyCode).HasMaxLength(4);
            entity.Property(e => e.CostCode).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryTime).HasMaxLength(50);
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 2)");
            entity.Property(e => e.DocType).HasMaxLength(4);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Expr2).HasMaxLength(5);
            entity.Property(e => e.HeaderText).HasMaxLength(50);
            entity.Property(e => e.Incoterms).HasMaxLength(3);
            entity.Property(e => e.IncotermsLocation).HasMaxLength(70);
            entity.Property(e => e.IsContract).HasMaxLength(100);
            entity.Property(e => e.IsItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCategory).HasMaxLength(10);
            entity.Property(e => e.ItemCode).HasMaxLength(18);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.ItemText).HasMaxLength(100);
            entity.Property(e => e.ItemType).HasMaxLength(10);
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LineHeaderText).HasMaxLength(40);
            entity.Property(e => e.LineStatus).HasMaxLength(20);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MaterialGroup).HasMaxLength(50);
            entity.Property(e => e.MaterialPotext)
                .HasMaxLength(100)
                .HasColumnName("MaterialPOText");
            entity.Property(e => e.MgrossPrice)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MGrossPrice");
            entity.Property(e => e.Mqty)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MQTY");
            entity.Property(e => e.MuoM)
                .HasMaxLength(4)
                .HasColumnName("MUoM");
            entity.Property(e => e.NetPrice).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Padescription)
                .HasMaxLength(100)
                .HasColumnName("PADescription");
            entity.Property(e => e.PadescriptionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PADescriptionStatus");
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Patype)
                .HasMaxLength(3)
                .HasColumnName("PAType");
            entity.Property(e => e.PlantCode).HasMaxLength(4);
            entity.Property(e => e.Ponum)
                .HasMaxLength(50)
                .HasColumnName("PONum");
            entity.Property(e => e.Prdate)
                .HasMaxLength(20)
                .HasColumnName("PRDate");
            entity.Property(e => e.PrkeyList)
                .HasMaxLength(50)
                .HasColumnName("PRKeyList");
            entity.Property(e => e.Prnum)
                .HasMaxLength(100)
                .HasColumnName("PRNum");
            entity.Property(e => e.PurGroup).HasMaxLength(3);
            entity.Property(e => e.PurOrg).HasMaxLength(4);
            entity.Property(e => e.RecordPotext)
                .HasMaxLength(100)
                .HasColumnName("RecordPOText");
            entity.Property(e => e.ReleaseGroup).HasMaxLength(50);
            entity.Property(e => e.ReleaseIndicator).HasMaxLength(20);
            entity.Property(e => e.ReleaseStrategy).HasMaxLength(50);
            entity.Property(e => e.SdocStatus)
                .HasMaxLength(20)
                .HasColumnName("SDocStatus");
            entity.Property(e => e.ServiceCode).HasMaxLength(18);
            entity.Property(e => e.ServiceName).HasMaxLength(200);
            entity.Property(e => e.ServicePercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SgrossPrice)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SGrossPrice");
            entity.Property(e => e.SlocCode)
                .HasMaxLength(4)
                .HasColumnName("SLocCode");
            entity.Property(e => e.Sqty)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SQTY");
            entity.Property(e => e.SubCom1).HasMaxLength(50);
            entity.Property(e => e.SubCom2).HasMaxLength(50);
            entity.Property(e => e.SubCom3).HasMaxLength(50);
            entity.Property(e => e.SubCom4).HasMaxLength(50);
            entity.Property(e => e.SubCom5).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SuoM)
                .HasMaxLength(3)
                .HasColumnName("SUoM");
            entity.Property(e => e.Sup1).HasMaxLength(150);
            entity.Property(e => e.Sup2).HasMaxLength(150);
            entity.Property(e => e.Sup3).HasMaxLength(150);
            entity.Property(e => e.Sup4).HasMaxLength(150);
            entity.Property(e => e.Sup5).HasMaxLength(150);
            entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TaxCode).HasMaxLength(10);
            entity.Property(e => e.TaxGroup).HasMaxLength(10);
            entity.Property(e => e.TermCode).HasMaxLength(4);
            entity.Property(e => e.TermCondition).HasMaxLength(132);
            entity.Property(e => e.TermPayment).HasMaxLength(132);
            entity.Property(e => e.TermRemark).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Uprice)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("UPrice");
        });

        modelBuilder.Entity<VPaapproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PAApproval");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Ponum)
                .HasMaxLength(50)
                .HasColumnName("PONum");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VPab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PAB");

            entity.Property(e => e.AccountAssignment).HasMaxLength(5);
            entity.Property(e => e.AfterDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AppDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveStatus).HasMaxLength(170);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelName).HasMaxLength(150);
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.CardPhone)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CardVatTin).HasMaxLength(50);
            entity.Property(e => e.CompanyCode).HasMaxLength(4);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorClarify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeliveryTime).HasMaxLength(50);
            entity.Property(e => e.Dep).HasMaxLength(100);
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 2)");
            entity.Property(e => e.DocType).HasMaxLength(4);
            entity.Property(e => e.ExchangeRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderText).HasMaxLength(50);
            entity.Property(e => e.HighRiskDes).HasMaxLength(50);
            entity.Property(e => e.Incoterms).HasMaxLength(3);
            entity.Property(e => e.IncotermsLocation).HasMaxLength(70);
            entity.Property(e => e.IntDate).HasColumnType("datetime");
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsContract).HasMaxLength(100);
            entity.Property(e => e.IsLegal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.NextApproverName).HasMaxLength(150);
            entity.Property(e => e.PacreatorName)
                .HasMaxLength(150)
                .HasColumnName("PACreatorName");
            entity.Property(e => e.Padescription)
                .HasMaxLength(100)
                .HasColumnName("PADescription");
            entity.Property(e => e.PadescriptionStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PADescriptionStatus");
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Patype)
                .HasMaxLength(3)
                .HasColumnName("PAType");
            entity.Property(e => e.Ponum)
                .HasMaxLength(53)
                .HasColumnName("PONum");
            entity.Property(e => e.Prdate)
                .HasMaxLength(20)
                .HasColumnName("PRDate");
            entity.Property(e => e.PrkeyList)
                .HasMaxLength(50)
                .HasColumnName("PRKeyList");
            entity.Property(e => e.Prnum)
                .HasMaxLength(100)
                .HasColumnName("PRNum");
            entity.Property(e => e.PurGroup).HasMaxLength(3);
            entity.Property(e => e.PurOrg).HasMaxLength(4);
            entity.Property(e => e.ReleaseGroup).HasMaxLength(50);
            entity.Property(e => e.ReleaseIndicator).HasMaxLength(20);
            entity.Property(e => e.ReleaseStrategy).HasMaxLength(50);
            entity.Property(e => e.Rownum).HasColumnName("rownum");
            entity.Property(e => e.SdocStatus)
                .HasMaxLength(20)
                .HasColumnName("SDocStatus");
            entity.Property(e => e.SubCom1).HasMaxLength(50);
            entity.Property(e => e.SubCom2).HasMaxLength(50);
            entity.Property(e => e.SubCom3).HasMaxLength(50);
            entity.Property(e => e.SubCom4).HasMaxLength(50);
            entity.Property(e => e.SubCom5).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Sup1).HasMaxLength(150);
            entity.Property(e => e.Sup2).HasMaxLength(150);
            entity.Property(e => e.Sup3).HasMaxLength(150);
            entity.Property(e => e.Sup4).HasMaxLength(150);
            entity.Property(e => e.Sup5).HasMaxLength(150);
            entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TaxGroup).HasMaxLength(10);
            entity.Property(e => e.TermCode).HasMaxLength(4);
            entity.Property(e => e.TermCondition).HasMaxLength(132);
            entity.Property(e => e.TermPayment).HasMaxLength(132);
            entity.Property(e => e.TermRemark).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VPr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PR");

            entity.Property(e => e.ApproveStatus).HasMaxLength(169);
            entity.Property(e => e.ApproverName).HasMaxLength(150);
            entity.Property(e => e.ApprvedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprvedDate2).HasColumnType("datetime");
            entity.Property(e => e.ApprvedUser).HasMaxLength(30);
            entity.Property(e => e.ApprvedUser2).HasMaxLength(30);
            entity.Property(e => e.AtchDoc).HasMaxLength(200);
            entity.Property(e => e.AutoCancel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BlockPa)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("BlockPA");
            entity.Property(e => e.Bpcode)
                .HasMaxLength(30)
                .HasColumnName("BPCode");
            entity.Property(e => e.Bpname)
                .HasMaxLength(100)
                .HasColumnName("BPName");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(30);
            entity.Property(e => e.Cancelreason).HasColumnName("cancelreason");
            entity.Property(e => e.CapexOpex).HasMaxLength(50);
            entity.Property(e => e.Clarifyuser)
                .HasMaxLength(50)
                .HasColumnName("clarifyuser");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(30);
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.DepName).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Direct)
                .HasMaxLength(50)
                .HasColumnName("direct");
            entity.Property(e => e.Division).HasMaxLength(100);
            entity.Property(e => e.DocAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(30);
            entity.Property(e => e.DocTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Hrt1).HasColumnName("HRT1");
            entity.Property(e => e.Hrt2).HasColumnName("HRT2");
            entity.Property(e => e.Hrt3).HasColumnName("HRT3");
            entity.Property(e => e.Hrt4).HasColumnName("HRT4");
            entity.Property(e => e.Hrt5).HasColumnName("HRT5");
            entity.Property(e => e.HrtapprovedStatus)
                .HasMaxLength(20)
                .HasColumnName("HRTApprovedStatus");
            entity.Property(e => e.IsCoi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IsCOI");
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nextapprover)
                .HasMaxLength(100)
                .HasColumnName("nextapprover");
            entity.Property(e => e.Pastatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAStatus");
            entity.Property(e => e.Postatus)
                .HasMaxLength(50)
                .HasColumnName("POStatus");
            entity.Property(e => e.Prcolor).HasColumnName("PRColor");
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.ProjectName).HasMaxLength(151);
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.RejectUser).HasMaxLength(30);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.Sapnum).HasColumnName("SAPNum");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusDesc).HasMaxLength(50);
            entity.Property(e => e.ToEmail).HasMaxLength(100);
            entity.Property(e => e.ToUserId).HasMaxLength(50);
            entity.Property(e => e.UApproBudget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_ApproBudget");
            entity.Property(e => e.UDepartment)
                .HasMaxLength(100)
                .HasColumnName("U_Department");
            entity.Property(e => e.UDivision)
                .HasMaxLength(100)
                .HasColumnName("U_Division");
            entity.Property(e => e.UDocType)
                .HasMaxLength(50)
                .HasColumnName("U_DocType");
            entity.Property(e => e.UFrmCtctRef)
                .HasMaxLength(100)
                .HasColumnName("U_FrmCtctRef");
            entity.Property(e => e.UIntegraCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_IntegraCode");
            entity.Property(e => e.UNameofSupp)
                .HasMaxLength(100)
                .HasColumnName("U_NameofSupp");
            entity.Property(e => e.UPhone)
                .HasMaxLength(50)
                .HasColumnName("U_Phone");
            entity.Property(e => e.UPurProcedure)
                .HasMaxLength(50)
                .HasColumnName("U_PurProcedure");
            entity.Property(e => e.UPurType)
                .HasMaxLength(50)
                .HasColumnName("U_PurType");
            entity.Property(e => e.URemarks).HasColumnName("U_Remarks");
            entity.Property(e => e.USupplier1)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier1");
            entity.Property(e => e.USupplier2)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier2");
            entity.Property(e => e.USupplier3)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier3");
            entity.Property(e => e.USupplier4)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier4");
            entity.Property(e => e.USupplier5)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier5");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(30);
            entity.Property(e => e.WaveApprovedStatus).HasMaxLength(20);
            entity.Property(e => e.Not_Title).HasColumnName("Not_Title");
            entity.Property(e => e.Not_Body).HasColumnName("Not_Body");
        });

        modelBuilder.Entity<VPr1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PR1");

            entity.Property(e => e.AmountAfDis).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ApproverName).HasMaxLength(150);
            entity.Property(e => e.ApprvedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprvedDate2).HasColumnType("datetime");
            entity.Property(e => e.ApprvedUser).HasMaxLength(30);
            entity.Property(e => e.ApprvedUser2).HasMaxLength(30);
            entity.Property(e => e.AtchDoc).HasMaxLength(200);
            entity.Property(e => e.BarCode).HasMaxLength(30);
            entity.Property(e => e.Bomcode)
                .HasMaxLength(30)
                .HasColumnName("BOMCode");
            entity.Property(e => e.Bpcode)
                .HasMaxLength(30)
                .HasColumnName("BPCode");
            entity.Property(e => e.Bpname)
                .HasMaxLength(100)
                .HasColumnName("BPName");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(30);
            entity.Property(e => e.Cancelreason).HasColumnName("cancelreason");
            entity.Property(e => e.Clarifyuser)
                .HasMaxLength(50)
                .HasColumnName("clarifyuser");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(30);
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.Direct)
                .HasMaxLength(50)
                .HasColumnName("direct");
            entity.Property(e => e.DisPercent).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(30);
            entity.Property(e => e.DocTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Expr2).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(30);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.Nextapprover)
                .HasMaxLength(100)
                .HasColumnName("nextapprover");
            entity.Property(e => e.Pastatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAStatus");
            entity.Property(e => e.PrexpenseType)
                .HasMaxLength(30)
                .HasColumnName("PRExpenseType");
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.RejectUser).HasMaxLength(30);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.Sapnum).HasColumnName("SAPNum");
            entity.Property(e => e.Section).HasMaxLength(30);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UApproBudget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_ApproBudget");
            entity.Property(e => e.UDepartment)
                .HasMaxLength(50)
                .HasColumnName("U_Department");
            entity.Property(e => e.UDivision)
                .HasMaxLength(50)
                .HasColumnName("U_Division");
            entity.Property(e => e.UDocType)
                .HasMaxLength(50)
                .HasColumnName("U_DocType");
            entity.Property(e => e.UFrmCtctRef)
                .HasMaxLength(100)
                .HasColumnName("U_FrmCtctRef");
            entity.Property(e => e.UIntegraCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_IntegraCode");
            entity.Property(e => e.UNameofSupp)
                .HasMaxLength(100)
                .HasColumnName("U_NameofSupp");
            entity.Property(e => e.UPhone)
                .HasMaxLength(50)
                .HasColumnName("U_Phone");
            entity.Property(e => e.UPurProcedure)
                .HasMaxLength(50)
                .HasColumnName("U_PurProcedure");
            entity.Property(e => e.UPurType)
                .HasMaxLength(50)
                .HasColumnName("U_PurType");
            entity.Property(e => e.URemarks).HasColumnName("U_Remarks");
            entity.Property(e => e.USupplier1)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier1");
            entity.Property(e => e.USupplier2)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier2");
            entity.Property(e => e.USupplier3)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier3");
            entity.Property(e => e.USupplier4)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier4");
            entity.Property(e => e.USupplier5)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier5");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UoM).HasMaxLength(30);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(30);
            entity.Property(e => e.VatCode).HasMaxLength(30);
            entity.Property(e => e.WhsCode).HasMaxLength(30);
        });

        modelBuilder.Entity<VPr1Balance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PR1_Balance");

            entity.Property(e => e.AmountAfDis).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ApplyQty).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.BarCode).HasMaxLength(30);
            entity.Property(e => e.Bomcode)
                .HasMaxLength(30)
                .HasColumnName("BOMCode");
            entity.Property(e => e.DisPercent).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(30);
            entity.Property(e => e.ItemName).HasMaxLength(300);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.Location).HasMaxLength(30);
            entity.Property(e => e.OriItemName).HasMaxLength(100);
            entity.Property(e => e.PrexpenseType)
                .HasMaxLength(30)
                .HasColumnName("PRExpenseType");
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.Section).HasMaxLength(30);
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.UoM).HasMaxLength(3);
            entity.Property(e => e.VatCode).HasMaxLength(10);
            entity.Property(e => e.WhsCode).HasMaxLength(30);
        });

        modelBuilder.Entity<VPrList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PR_List");

            entity.Property(e => e.ApproveStatus).HasMaxLength(169);
            entity.Property(e => e.ApproverName).HasMaxLength(150);
            entity.Property(e => e.ApprvedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprvedDate2).HasColumnType("datetime");
            entity.Property(e => e.ApprvedUser).HasMaxLength(30);
            entity.Property(e => e.ApprvedUser2).HasMaxLength(30);
            entity.Property(e => e.AtchDoc).HasMaxLength(200);
            entity.Property(e => e.AutoCancel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bpcode)
                .HasMaxLength(30)
                .HasColumnName("BPCode");
            entity.Property(e => e.Bpname)
                .HasMaxLength(100)
                .HasColumnName("BPName");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(30);
            entity.Property(e => e.Cancelreason).HasColumnName("cancelreason");
            entity.Property(e => e.CapexOpex).HasMaxLength(50);
            entity.Property(e => e.Clarifyuser)
                .HasMaxLength(50)
                .HasColumnName("clarifyuser");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(30);
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.DepName).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Direct)
                .HasMaxLength(50)
                .HasColumnName("direct");
            entity.Property(e => e.Division).HasMaxLength(100);
            entity.Property(e => e.DocAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(30);
            entity.Property(e => e.DocTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nextapprover)
                .HasMaxLength(100)
                .HasColumnName("nextapprover");
            entity.Property(e => e.Pastatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAStatus");
            entity.Property(e => e.Postatus)
                .HasMaxLength(50)
                .HasColumnName("POStatus");
            entity.Property(e => e.Prcolor).HasColumnName("PRColor");
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.RejectUser).HasMaxLength(30);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.Sapnum).HasColumnName("SAPNum");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusDesc).HasMaxLength(50);
            entity.Property(e => e.UApproBudget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_ApproBudget");
            entity.Property(e => e.UDepartment)
                .HasMaxLength(50)
                .HasColumnName("U_Department");
            entity.Property(e => e.UDivision)
                .HasMaxLength(50)
                .HasColumnName("U_Division");
            entity.Property(e => e.UDocType)
                .HasMaxLength(50)
                .HasColumnName("U_DocType");
            entity.Property(e => e.UFrmCtctRef)
                .HasMaxLength(100)
                .HasColumnName("U_FrmCtctRef");
            entity.Property(e => e.UIntegraCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_IntegraCode");
            entity.Property(e => e.UNameofSupp)
                .HasMaxLength(100)
                .HasColumnName("U_NameofSupp");
            entity.Property(e => e.UPhone)
                .HasMaxLength(50)
                .HasColumnName("U_Phone");
            entity.Property(e => e.UPurProcedure)
                .HasMaxLength(50)
                .HasColumnName("U_PurProcedure");
            entity.Property(e => e.UPurType)
                .HasMaxLength(50)
                .HasColumnName("U_PurType");
            entity.Property(e => e.URemarks).HasColumnName("U_Remarks");
            entity.Property(e => e.USupplier1)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier1");
            entity.Property(e => e.USupplier2)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier2");
            entity.Property(e => e.USupplier3)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier3");
            entity.Property(e => e.USupplier4)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier4");
            entity.Property(e => e.USupplier5)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier5");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(30);
        });

        modelBuilder.Entity<VPrapproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PRApproval");

            entity.Property(e => e.Changeuser)
                .HasMaxLength(50)
                .HasColumnName("changeuser");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Dockey).HasColumnName("dockey");
            entity.Property(e => e.Docstatus)
                .HasMaxLength(20)
                .HasColumnName("docstatus");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");
            entity.Property(e => e.Visorder).HasColumnName("visorder");
        });

        modelBuilder.Entity<VPrb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PRB");

            entity.Property(e => e.ApproveStatus).HasMaxLength(169);
            entity.Property(e => e.ApproverName).HasMaxLength(150);
            entity.Property(e => e.ApprvedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprvedDate2).HasColumnType("datetime");
            entity.Property(e => e.ApprvedUser).HasMaxLength(30);
            entity.Property(e => e.ApprvedUser2).HasMaxLength(30);
            entity.Property(e => e.AtchDoc).HasMaxLength(200);
            entity.Property(e => e.AutoCancel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Bpcode)
                .HasMaxLength(30)
                .HasColumnName("BPCode");
            entity.Property(e => e.Bpname)
                .HasMaxLength(100)
                .HasColumnName("BPName");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelUser).HasMaxLength(30);
            entity.Property(e => e.Cancelreason).HasColumnName("cancelreason");
            entity.Property(e => e.CapexOpex).HasMaxLength(50);
            entity.Property(e => e.Clarifyuser)
                .HasMaxLength(50)
                .HasColumnName("clarifyuser");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(30);
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.DepName).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Direct)
                .HasMaxLength(50)
                .HasColumnName("direct");
            entity.Property(e => e.Division).HasMaxLength(100);
            entity.Property(e => e.DocAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(30);
            entity.Property(e => e.DocTotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IsCoi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IsCOI");
            entity.Property(e => e.MailAction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nextapprover)
                .HasMaxLength(100)
                .HasColumnName("nextapprover");
            entity.Property(e => e.Pastatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAStatus");
            entity.Property(e => e.Postatus)
                .HasMaxLength(50)
                .HasColumnName("POStatus");
            entity.Property(e => e.Prcolor).HasColumnName("PRColor");
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.Project).HasMaxLength(20);
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.RejectDate).HasColumnType("datetime");
            entity.Property(e => e.RejectUser).HasMaxLength(30);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.Sapnum).HasColumnName("SAPNum");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusDesc).HasMaxLength(50);
            entity.Property(e => e.UApproBudget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_ApproBudget");
            entity.Property(e => e.UDepartment)
                .HasMaxLength(50)
                .HasColumnName("U_Department");
            entity.Property(e => e.UDivision)
                .HasMaxLength(50)
                .HasColumnName("U_Division");
            entity.Property(e => e.UDocType)
                .HasMaxLength(50)
                .HasColumnName("U_DocType");
            entity.Property(e => e.UFrmCtctRef)
                .HasMaxLength(100)
                .HasColumnName("U_FrmCtctRef");
            entity.Property(e => e.UIntegraCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("U_IntegraCode");
            entity.Property(e => e.UNameofSupp)
                .HasMaxLength(100)
                .HasColumnName("U_NameofSupp");
            entity.Property(e => e.UPhone)
                .HasMaxLength(50)
                .HasColumnName("U_Phone");
            entity.Property(e => e.UPurProcedure)
                .HasMaxLength(50)
                .HasColumnName("U_PurProcedure");
            entity.Property(e => e.UPurType)
                .HasMaxLength(50)
                .HasColumnName("U_PurType");
            entity.Property(e => e.URemarks).HasColumnName("U_Remarks");
            entity.Property(e => e.USupplier1)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier1");
            entity.Property(e => e.USupplier2)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier2");
            entity.Property(e => e.USupplier3)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier3");
            entity.Property(e => e.USupplier4)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier4");
            entity.Property(e => e.USupplier5)
                .HasMaxLength(200)
                .HasColumnName("U_Supplier5");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(30);
        });

        modelBuilder.Entity<VPrhrtapproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PRHRTApproval");

            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VPrwavier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PRWavier");

            entity.Property(e => e.Changeuser)
                .HasMaxLength(50)
                .HasColumnName("changeuser");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Dockey).HasColumnName("dockey");
            entity.Property(e => e.Docstatus)
                .HasMaxLength(20)
                .HasColumnName("docstatus");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");
            entity.Property(e => e.Visorder).HasColumnName("visorder");
        });

        modelBuilder.Entity<VSesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SES_Detail");

            entity.Property(e => e.ApprovalUpdated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BaseEntry).HasMaxLength(20);
            entity.Property(e => e.BaseType).HasMaxLength(20);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelReason).HasMaxLength(300);
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.Cancelleddate).HasColumnType("datetime");
            entity.Property(e => e.CardAddress).HasMaxLength(200);
            entity.Property(e => e.CardCode).HasMaxLength(10);
            entity.Property(e => e.CardNam).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocAction).HasMaxLength(15);
            entity.Property(e => e.DocCur).HasMaxLength(5);
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.ExternalNum).HasMaxLength(50);
            entity.Property(e => e.HighRiskDes).HasMaxLength(50);
            entity.Property(e => e.IntStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.ItemName).HasMaxLength(50);
            entity.Property(e => e.LastApprover).HasMaxLength(50);
            entity.Property(e => e.LastError).HasMaxLength(300);
            entity.Property(e => e.LineAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LineIntegration)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LineLastError).HasMaxLength(100);
            entity.Property(e => e.LineRemark).HasMaxLength(200);
            entity.Property(e => e.LineSapnum)
                .HasMaxLength(50)
                .HasColumnName("LineSAPNum");
            entity.Property(e => e.LineStatus).HasMaxLength(15);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LongText).HasMaxLength(100);
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.Panum)
                .HasMaxLength(20)
                .HasColumnName("PANum");
            entity.Property(e => e.Ponum)
                .HasMaxLength(20)
                .HasColumnName("PONum");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("QTY");
            entity.Property(e => e.Reason).HasMaxLength(300);
            entity.Property(e => e.Ref).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(16);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.Sapnum)
                .HasMaxLength(20)
                .HasColumnName("SAPNum");
            entity.Property(e => e.ServiceLocation).HasMaxLength(50);
            entity.Property(e => e.Sesnum)
                .HasMaxLength(20)
                .HasColumnName("SESNum");
            entity.Property(e => e.SesnumLineNo)
                .HasMaxLength(51)
                .HasColumnName("SESNumLineNo");
            entity.Property(e => e.Term).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UoM).HasMaxLength(3);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VSo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_SO");

            entity.Property(e => e.AccountAssignment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AfterDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AppBy).HasMaxLength(50);
            entity.Property(e => e.AppDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveStatus).HasMaxLength(169);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.ClarifyUser).HasMaxLength(100);
            entity.Property(e => e.CompanyAddrss).HasMaxLength(100);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.Division).HasMaxLength(20);
            entity.Property(e => e.DocCur).HasMaxLength(3);
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.NextApproverName).HasMaxLength(150);
            entity.Property(e => e.ObjType).HasMaxLength(2);
            entity.Property(e => e.RejBy).HasMaxLength(50);
            entity.Property(e => e.RejDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(100);
            entity.Property(e => e.SrdocDate).HasColumnName("SRDocDate");
            entity.Property(e => e.SrdocNum)
                .HasMaxLength(20)
                .HasColumnName("SRDocNum");
            entity.Property(e => e.StypeCode).HasColumnName("STypeCode");
            entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TermCondition).HasMaxLength(300);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedCompleted)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VatCode).HasMaxLength(5);
            entity.Property(e => e.Vatamount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("VATAmount");
        });

        modelBuilder.Entity<VSo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SO1");

            entity.Property(e => e.BaseDocNum).HasMaxLength(20);
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.LineStatus).HasMaxLength(20);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SiteCode).HasMaxLength(50);
            entity.Property(e => e.SiteName).HasMaxLength(100);
            entity.Property(e => e.UoM).HasMaxLength(20);
        });

        modelBuilder.Entity<VSoapproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SOApproval");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocStatusApp).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VSr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SR");

            entity.Property(e => e.AppBy).HasMaxLength(50);
            entity.Property(e => e.AppDate).HasColumnType("datetime");
            entity.Property(e => e.ApproveStatus).HasMaxLength(169);
            entity.Property(e => e.CancelBy).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.ClarifyUser).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorName).HasMaxLength(150);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Div).HasMaxLength(100);
            entity.Property(e => e.Division).HasMaxLength(20);
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FrameContract).HasMaxLength(100);
            entity.Property(e => e.NameOfSupplier).HasMaxLength(100);
            entity.Property(e => e.NextApprover).HasMaxLength(50);
            entity.Property(e => e.NextApproverName).HasMaxLength(150);
            entity.Property(e => e.ObjType).HasMaxLength(2);
            entity.Property(e => e.PotentialName).HasMaxLength(100);
            entity.Property(e => e.PrintedDate).HasColumnType("datetime");
            entity.Property(e => e.PrintedName).HasMaxLength(50);
            entity.Property(e => e.ProcRoute).HasMaxLength(30);
            entity.Property(e => e.Project).HasMaxLength(50);
            entity.Property(e => e.RejBy).HasMaxLength(50);
            entity.Property(e => e.RejDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceTypeName).HasMaxLength(100);
            entity.Property(e => e.Sostatus)
                .HasMaxLength(30)
                .HasColumnName("SOStatus");
            entity.Property(e => e.StypeCode).HasColumnName("STypeCode");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VSr1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SR1");

            entity.Property(e => e.AppliedAmt).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.BalanceAmt).HasColumnType("numeric(21, 2)");
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.LineStatus).HasMaxLength(20);
            entity.Property(e => e.LineTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SiteCode).HasMaxLength(50);
            entity.Property(e => e.SiteName).HasMaxLength(100);
            entity.Property(e => e.UoM).HasMaxLength(20);
        });

        modelBuilder.Entity<VSrapproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SRApproval");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeUser).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocNum).HasMaxLength(20);
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocStatusApp).HasMaxLength(20);
            entity.Property(e => e.MailDate).HasColumnType("datetime");
            entity.Property(e => e.MailStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });
        modelBuilder.Entity<PRItemList>(entity =>
        {
            entity.HasNoKey(); // This makes EF treat it as keyless
            entity.ToView(null); // Optional: prevent EF from mapping it to a table
        });
        modelBuilder.Entity<PAItemList>(entity =>
        {
            entity.HasNoKey(); // This makes EF treat it as keyless
            entity.ToView(null); // Optional: prevent EF from mapping it to a table
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
