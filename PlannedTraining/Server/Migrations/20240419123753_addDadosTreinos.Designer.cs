﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlannedTraining.Server.Context;

#nullable disable

namespace PlannedTraining.Server.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20240419123753_addDadosTreinos")]
    partial class addDadosTreinos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PlannedTraining.Shared.Models.Aluno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RegistroAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<bool>("RegistroAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Exercicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RegistroAtivo")
                        .HasColumnType("bit");

                    b.Property<int>("Repeticoes")
                        .HasColumnType("int");

                    b.Property<long>("TreinoId")
                        .HasColumnType("bigint");

                    b.Property<int>("series")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TreinoId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Treino", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataTreino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeTreino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RegistroAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Endereco", b =>
                {
                    b.HasOne("PlannedTraining.Shared.Models.Aluno", null)
                        .WithOne("Endereco")
                        .HasForeignKey("PlannedTraining.Shared.Models.Endereco", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Exercicio", b =>
                {
                    b.HasOne("PlannedTraining.Shared.Models.Treino", null)
                        .WithMany("Exercicios")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Treino", b =>
                {
                    b.HasOne("PlannedTraining.Shared.Models.Aluno", null)
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Aluno", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("PlannedTraining.Shared.Models.Treino", b =>
                {
                    b.Navigation("Exercicios");
                });
#pragma warning restore 612, 618
        }
    }
}
