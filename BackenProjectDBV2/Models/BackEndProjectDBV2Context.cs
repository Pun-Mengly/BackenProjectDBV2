using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BackenProjectDBV2.Models
{
    public partial class BackEndProjectDBV2Context : DbContext
    {
        public BackEndProjectDBV2Context()
        {
        }

        public BackEndProjectDBV2Context(DbContextOptions<BackEndProjectDBV2Context> options)
            : base(options)
        {
        }

        public  DbSet<Attendance> Attendances { get; set; }
        public  DbSet<Class> Classes { get; set; }
        public  DbSet<ClassDetail> ClassDetails { get; set; }
        public  DbSet<Department> Departments { get; set; }
        public  DbSet<Guardian> Guardians { get; set; }
        public  DbSet<Info> Infos { get; set; }
        public  DbSet<Major> Majors { get; set; }
        public  DbSet<MajorDetail> MajorDetails { get; set; }
        public  DbSet<MajorShiftTime> MajorShiftTimes { get; set; }
        public  DbSet<Mark> Marks { get; set; }
        public  DbSet<MarkType> MarkTypes { get; set; }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Subject> Subjects { get; set; }
        public  DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL5061.site4now.net;Database=db_a77af1_mengly;User Id=db_a77af1_mengly_admin;Password=Pm11223344");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.AttNo)
                    .HasName("PK__Attendan__02DC414B60264E64");

                entity.ToTable("Attendance");

                entity.Property(e => e.AttNo).HasColumnName("attNo");

                entity.Property(e => e.AttDate)
                    .HasColumnType("date")
                    .HasColumnName("attDate");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK__Attendanc__stuID__300424B4");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClaNo)
                    .HasName("PK__Class__71E27CB6777C4D5D");

                entity.ToTable("Class");

                entity.Property(e => e.ClaNo)
                    .ValueGeneratedNever()
                    .HasColumnName("claNo");

                entity.Property(e => e.Building)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("building")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ClassDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClassDetail");

                entity.Property(e => e.ClaNo).HasColumnName("claNo");

                entity.Property(e => e.MajNo).HasColumnName("majNo");

                entity.HasOne(d => d.ClaNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ClaNo)
                    .HasConstraintName("FK__ClassDeta__claNo__1DE57479");

                entity.HasOne(d => d.MajNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MajNo)
                    .HasConstraintName("FK__ClassDeta__majNo__1ED998B2");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepNo)
                    .HasName("PK__Departme__00D78A40AC07DDAC");

                entity.ToTable("Department");

                entity.Property(e => e.DepNo).HasColumnName("depNo");

                entity.Property(e => e.DepName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("depName");
            });

            modelBuilder.Entity<Guardian>(entity =>
            {
                entity.HasKey(e => e.GuaId)
                    .HasName("PK__Guardian__88DC0F0493F78013");

                entity.ToTable("Guardian");

                entity.Property(e => e.GuaId).HasColumnName("guaID");

                entity.Property(e => e.GuaAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("guaAdd");

                entity.Property(e => e.GuaFname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("guaFName");

                entity.Property(e => e.GuaLname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("guaLName");

                entity.Property(e => e.GuaPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("guaPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.GuaSex)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("guaSex");
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.ToTable("info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Context).HasColumnName("context");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Image).HasColumnName("image");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.MajNo)
                    .HasName("PK__Major__11138C96CBD91B75");

                entity.ToTable("Major");

                entity.Property(e => e.MajNo).HasColumnName("majNo");

                entity.Property(e => e.DepNo).HasColumnName("depNo");

                entity.Property(e => e.MajDes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("majDes");

                entity.Property(e => e.MajDur).HasColumnName("majDur");

                entity.Property(e => e.MajName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("majName");

                entity.HasOne(d => d.DepNoNavigation)
                    .WithMany(p => p.Majors)
                    .HasForeignKey(d => d.DepNo)
                    .HasConstraintName("FK__Major__depNo__1273C1CD");
            });

            modelBuilder.Entity<MajorDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MajorDetail");

                entity.Property(e => e.MajNo).HasColumnName("majNo");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.HasOne(d => d.MajNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MajNo)
                    .HasConstraintName("FK__MajorDeta__majNo__25869641");

                entity.HasOne(d => d.Stu)
                    .WithMany()
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK__MajorDeta__stuID__267ABA7A");
            });

            modelBuilder.Entity<MajorShiftTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MajorShiftTime");

                entity.Property(e => e.MajNo).HasColumnName("majNo");

                entity.Property(e => e.MajTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("majTime");

                entity.HasOne(d => d.MajNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MajNo)
                    .HasConstraintName("FK__MajorShif__majNo__145C0A3F");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasKey(e => e.MarNo)
                    .HasName("PK__Mark__0B63AC8F8D5E2368");

                entity.ToTable("Mark");

                entity.Property(e => e.MarNo).HasColumnName("marNo");

                entity.Property(e => e.MarDate)
                    .HasColumnType("date")
                    .HasColumnName("marDate");

                entity.Property(e => e.MarTotal).HasColumnName("marTotal");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.SubNo).HasColumnName("subNo");

                entity.Property(e => e.TypeNo).HasColumnName("typeNo");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK__Mark__stuID__2D27B809");

                entity.HasOne(d => d.SubNoNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SubNo)
                    .HasConstraintName("FK__Mark__subNo__2C3393D0");

                entity.HasOne(d => d.TypeNoNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.TypeNo)
                    .HasConstraintName("FK__Mark__typeNo__2B3F6F97");
            });

            modelBuilder.Entity<MarkType>(entity =>
            {
                entity.HasKey(e => e.TypeNo)
                    .HasName("PK__MarkType__F04D26F040BB8F6F");

                entity.ToTable("MarkType");

                entity.Property(e => e.TypeNo).HasColumnName("typeNo");

                entity.Property(e => e.MarMax).HasColumnName("marMax");

                entity.Property(e => e.MarType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("marType");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuId)
                    .HasName("PK__Student__AEC9BFAFE99D9EA7");

                entity.ToTable("Student");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.GuaId).HasColumnName("guaID");

                entity.Property(e => e.StuAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stuAdd");

                entity.Property(e => e.StuDob)
                    .HasColumnType("date")
                    .HasColumnName("stuDOB");

                entity.Property(e => e.StuFname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("stuFName");

                entity.Property(e => e.StuLname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("stuLName");

                entity.Property(e => e.StuPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stuPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.StuSex)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("stuSex");

                entity.Property(e => e.StuYear).HasColumnName("stuYear");

                entity.HasOne(d => d.Gua)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GuaId)
                    .HasConstraintName("FK__Student__guaID__239E4DCF");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubNo)
                    .HasName("PK__Subject__B0F160FB529EF2FF");

                entity.ToTable("Subject");

                entity.Property(e => e.SubNo).HasColumnName("subNo");

                entity.Property(e => e.MajNo).HasColumnName("majNo");

                entity.Property(e => e.SubDur).HasColumnName("subDur");

                entity.Property(e => e.SubName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("subName");

                entity.HasOne(d => d.MajNoNavigation)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.MajNo)
                    .HasConstraintName("FK__Subject__majNo__173876EA");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeaId)
                    .HasName("PK__Teacher__F6941A22A710F3EA");

                entity.ToTable("Teacher");

                entity.Property(e => e.TeaId).HasColumnName("teaID");

                entity.Property(e => e.SubNo).HasColumnName("subNo");

                entity.Property(e => e.TeaAdd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("teaAdd");

                entity.Property(e => e.TeaDob)
                    .HasColumnType("date")
                    .HasColumnName("teaDOB");

                entity.Property(e => e.TeaFname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("teaFName");

                entity.Property(e => e.TeaLname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("teaLName");

                entity.Property(e => e.TeaPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("teaPhone")
                    .IsFixedLength(true);

                entity.Property(e => e.TeaSex)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("teaSex");

                entity.HasOne(d => d.SubNoNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.SubNo)
                    .HasConstraintName("FK__Teacher__subNo__1A14E395");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
