using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApi.KaniniModel
{
    public partial class stationaryContext : DbContext
    {
        public stationaryContext()
        {
        }

        public stationaryContext(DbContextOptions<stationaryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddCart> AddCarts { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookingT> BookingTs { get; set; }
        public virtual DbSet<Chaat> Chaats { get; set; }
        public virtual DbSet<ChaatsCart> ChaatsCarts { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<DrinksCart> DrinksCarts { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Logintabl> Logintabls { get; set; }
        public virtual DbSet<Logintbl> Logintbls { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<ProductsBooking> ProductsBookings { get; set; }
        public virtual DbSet<ProductsCart> ProductsCarts { get; set; }
        public virtual DbSet<Sbaccount> Sbaccounts { get; set; }
        public virtual DbSet<Sbtransaction> Sbtransactions { get; set; }
        public virtual DbSet<ShipmentDetail> ShipmentDetails { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:movirticket.database.windows.net,1433;Initial Catalog=stationary;Persist Security Info=False;User ID=Team8;Password=Teammovie@8;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddCart>(entity =>
            {
                entity.ToTable("AddCart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.PlotDescription).IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Photo)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.PlotDescription).IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<BookingT>(entity =>
            {
                entity.ToTable("bookingT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MovieDescription)
                    .HasMaxLength(500)
                    .IsFixedLength(true);

                entity.Property(e => e.MovieName)
                    .HasMaxLength(70)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Chaat>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Chaats__C1F8DC399D45F94F");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CId");

                entity.Property(e => e.Cimage)
                    .HasMaxLength(20)
                    .HasColumnName("CImage");

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CName");

                entity.Property(e => e.Cprice).HasColumnName("CPrice");
            });

            modelBuilder.Entity<ChaatsCart>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__ChaatsCa__C1F8DC39395B7D5F");

                entity.ToTable("ChaatsCart");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CId");

                entity.Property(e => e.Cimage)
                    .HasMaxLength(20)
                    .HasColumnName("CImage");

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CName");

                entity.Property(e => e.Cprice).HasColumnName("CPrice");
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Drinks__C03656507DD60EB7");

                entity.Property(e => e.Did)
                    .ValueGeneratedNever()
                    .HasColumnName("DId");

                entity.Property(e => e.Dimage)
                    .HasMaxLength(20)
                    .HasColumnName("DImage");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DName");
            });

            modelBuilder.Entity<DrinksCart>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__DrinksCa__C036565090A969B1");

                entity.ToTable("DrinksCart");

                entity.Property(e => e.Did)
                    .ValueGeneratedNever()
                    .HasColumnName("DId");

                entity.Property(e => e.Dimage)
                    .HasMaxLength(20)
                    .HasColumnName("DImage");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DName");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.ToTable("employe");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Logintabl>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("Logintabl");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("Login id");

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Logintbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logintbl");

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.HasKey(e => e.CvvPin)
                    .HasName("PK__PaymentD__B940F7F1F563307B");

                entity.Property(e => e.CvvPin)
                    .ValueGeneratedNever()
                    .HasColumnName("Cvv_Pin");

                entity.Property(e => e.CardHolderName)
                    .IsUnicode(false)
                    .HasColumnName("Card_Holder_Name");

                entity.Property(e => e.DebitCardNumber).HasColumnName("Debit_Card_Number");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiry_Date");
            });

            modelBuilder.Entity<ProductsBooking>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PK__Products__2D172D32831E2C4F");

                entity.ToTable("ProductsBooking");

                entity.Property(e => e.Productid)
                    .ValueGeneratedNever()
                    .HasColumnName("productid");

                entity.Property(e => e.ProductImage).HasColumnName("product image");

                entity.Property(e => e.Productname)
                    .HasMaxLength(100)
                    .HasColumnName("productname")
                    .IsFixedLength(true);

                entity.Property(e => e.Productprice).HasColumnName("productprice");
            });

            modelBuilder.Entity<ProductsCart>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PK__Products__2D172D329FB6C810");

                entity.ToTable("ProductsCart");

                entity.Property(e => e.Productid)
                    .ValueGeneratedNever()
                    .HasColumnName("productid");

                entity.Property(e => e.ProductImage).HasColumnName("product image");

                entity.Property(e => e.Productname)
                    .HasMaxLength(100)
                    .HasColumnName("productname")
                    .IsFixedLength(true);

                entity.Property(e => e.Productprice).HasColumnName("productprice");
            });

            modelBuilder.Entity<Sbaccount>(entity =>
            {
                entity.HasKey(e => e.Accno)
                    .HasName("PK__sbaccoun__A472931D0464BD0B");

                entity.ToTable("sbaccount");

                entity.Property(e => e.Accno)
                    .ValueGeneratedNever()
                    .HasColumnName("accno");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Custaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("custaddress");

                entity.Property(e => e.Custname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("custname");

                entity.Property(e => e.Transtype)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("transtype");
            });

            modelBuilder.Entity<Sbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transid)
                    .HasName("PK__sbtransa__DB1F6ABF10070997");

                entity.ToTable("sbtransaction");

                entity.Property(e => e.Transid).HasColumnName("transid");

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.Transactdate)
                    .HasColumnType("datetime")
                    .HasColumnName("transactdate");

                entity.Property(e => e.Transtype)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("transtype");

                entity.HasOne(d => d.AccnoNavigation)
                    .WithMany(p => p.Sbtransactions)
                    .HasForeignKey(d => d.Accno)
                    .HasConstraintName("FK__sbtransac__accno__619B8048");
            });

            modelBuilder.Entity<ShipmentDetail>(entity =>
            {
                entity.HasKey(e => e.MobileNumber)
                    .HasName("PK__Shipment__C892EBD78C24F66C");

                entity.Property(e => e.MobileNumber).HasColumnName("Mobile_Number");

                entity.Property(e => e.AddressDetails)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasColumnName("Address_Details");

                entity.Property(e => e.BuyersName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Buyers_Name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("students");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
