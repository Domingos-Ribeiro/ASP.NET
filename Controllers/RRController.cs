using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using EquipasMembros.DAL;

namespace EquipasMembros.Controllers
{
    public class RRController : Controller
    {

        EquipasMembrosContext pointer = new EquipasMembrosContext();

        //private string Remota =
        //          "data source = 188.121.44.214;" +
        //          "Initial Catalog = EM;" +
        //          "User Id= bdz04;" +
        //          "Password=123.Abc.@;";

        //private string LocalSQL = "";


        // GET: RR
        public ActionResult Index()
        {
            // Apagar Todas as Equipas Recolonizar por estas Novas Equipas
            pointer.Database.ExecuteSqlCommand("DELETE FROM Equipas;" +
                    "DBCC CHECKIDENT(Equipas, reseed, 1); " +
                    "SET IDENTITY_INSERT[dbo].[Equipas] ON;" +
                    "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES (1, 'Falcões do Picoto');" +
                    "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES (2, 'Arsenal da Devesa');" +
                    "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES (3, 'Ases de Fraião');" +
                    "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES (4, 'Leões da Tecla');" +
                    "INSERT[dbo].[Equipas]([Id], [NomeEquipa]) VALUES (5, 'Maximinense');" +
                    "SET IDENTITY_INSERT[dbo].[Equipas] OFF;");


            // Apagar Todas os Membros das Equipas Recolonizar por estes Novos
            pointer.Database.ExecuteSqlCommand("DELETE FROM Membroes;" +
                    "DBCC CHECKIDENT(Membroes, reseed, 1); " +
                    "SET IDENTITY_INSERT[dbo].[Membroes] ON;" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (1, 'Carlinhos', 1);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (2, 'Afonsinho', 1);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (3, 'Abel', 2);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (4, 'Ana', 1);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (5, 'Arlindo', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (6, 'Rosa', 1);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (7, 'Adriano', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (8, 'António', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (9, 'Alexandre', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (10, 'Amélia', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (11, 'Sandra', 5);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (12, 'Teresa', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (13, 'Isabelinha', 5);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (14, 'Abel', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (15, 'Joana', 4);" +
                    "INSERT[dbo].[Membroes]([Id], [NomeMembro], [EquipaId]) VALUES (16, 'Domingos', 3);" +

                    "SET IDENTITY_INSERT[dbo].[Membroes] OFF;");

            return View();
        }
    }
}