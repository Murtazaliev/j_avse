using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//Scaffold-DbContext "Data Source=MURAD-PC\SQLEXPRESS;Initial Catalog=JOURNAL_NEOP;Integrated Security=True"
//Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models1
namespace JournalNOEP_DOMAIN
{
    public partial class NEOPContext : DbContext
    {
        public NEOPContext()
        {
        }

        public NEOPContext(DbContextOptions<NEOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<DataArticleAuthors> DataArticleAuthors { get; set; }
        public virtual DbSet<DataEdition> DataEdition { get; set; }
        public virtual DbSet<DataYear> DataYear { get; set; }
        public virtual DbSet<SprJoiurnalAuthors> SprJoiurnalAuthors { get; set; }
        public virtual DbSet<DataInfo> DataInfo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.ToTable("articles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtAnnotation).HasColumnName("art_annotation");
                entity.Property(e => e.ArtKeywords).HasColumnName("art_keywords");

                entity.Property(e => e.ArtAnnotationEng).HasColumnName("art_annotation_eng");
                entity.Property(e => e.ArtKeywordsEng).HasColumnName("art_keywords_eng");
                entity.Property(e => e.ArtPos).HasColumnName("art_pos");

                entity.Property(e => e.ArtFile)
                    .IsRequired()
                    .HasColumnName("art_file")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtFileXml)
                    .IsRequired()
                    .HasColumnName("art_file_xml")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtName)
                    .IsRequired()
                    .HasColumnName("art_name")
                    .HasMaxLength(350);

                entity.Property(e => e.ArtNameEng)
                    .HasColumnName("art_name_eng")
                    .HasMaxLength(350);

                entity.Property(e => e.ArtUdk)
                    .HasColumnName("art_udk")
                    .HasMaxLength(50);

                entity.Property(e => e.EditionId).HasColumnName("edition_id");


                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_articles_data_edition");

            });

            modelBuilder.Entity<DataArticleAuthors>(entity =>
            {
                entity.ToTable("data_article_authors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId).HasColumnName("article_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.AuthorPos).HasColumnName("author_pos");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.DataArticleAuthors)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_articles_spr_journal_authors_");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.DataArticleAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_articles_spr_journal_authors");
            });

            modelBuilder.Entity<DataEdition>(entity =>
            {
                entity.ToTable("data_edition");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Edition).HasColumnName("edition");

                entity.Property(e => e.IdYear).HasColumnName("id_year");

                entity.Property(e => e.EdFile).HasColumnName("ed_file");

                entity.Property(e => e.EdFileExt).HasColumnName("ed_file_ext");

                entity.Property(e => e.AdditionalEdition).HasColumnName("additional_edition");

                entity.Property(e => e.DateLastArticle).HasColumnName("date_last_article")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdYearNavigation)
                    .WithMany(p => p.DataEdition)
                    .HasForeignKey(d => d.IdYear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_data_edition_data_year");
            });

            modelBuilder.Entity<DataYear>(entity =>
            {
                entity.ToTable("data_year");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SprJoiurnalAuthors>(entity =>
            {
                entity.ToTable("spr_joiurnal_authors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthFio)
                    .IsRequired()
                    .HasColumnName("auth_fio")
                    .HasMaxLength(50);

                entity.Property(e => e.AuthFioEng)
                    .HasColumnName("auth_fio_eng")
                    .HasMaxLength(50);

                entity.Property(e => e.AuthRegal)
                    .HasColumnName("auth_regal")
                    .HasMaxLength(1050);

                entity.Property(e => e.AuthRegalEng)
                    .HasColumnName("auth_regal_eng")
                    .HasMaxLength(1050);

                entity.Property(e => e.AuthJobMail)
                    .HasColumnName("auth_job_mail")
                    .HasMaxLength(550);

                entity.Property(e => e.AuthJobMailEng)
                    .HasColumnName("auth_job_mail_eng")
                    .HasMaxLength(550);
            });


            modelBuilder.Entity<DataInfo>(entity =>
            {
                entity.ToTable("data_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfoNameEn)
                    .HasColumnName("info_name_en")
                    .HasMaxLength(50);

                entity.Property(e => e.InfoNameRu)
                    .HasColumnName("info_name_ru")
                    .HasMaxLength(50);

                entity.Property(e => e.InfoTextEn).HasColumnName("info_text_en");

                entity.Property(e => e.InfoTextRu).HasColumnName("info_text_ru");

                entity.Property(e => e.InfoPageNum).HasColumnName("info_page_num");

                entity.Property(e => e.IsSectionOnMainPage).HasColumnName("is_section_on_main_page");
            });
        }
    }
}
