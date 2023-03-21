using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_EF6_DF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region 1. Declarar o Contexto de BD (Instanciar a DB Context)
            var db = new NorthwindEntities();                           // permite-me aceder à conection string e aos DBSets
            #endregion

            #region 2. Usar o contexto de BD
            using (db)
            {
                
                #region Nova Region (1)
                Region region01 = new Region();
                Region region02 = new Region();
                Region region03 = new Region();

                region01.RegionID = 5;                                   // não é identity
                region01.RegionDescription = "Norte";

                region02.RegionID = 6;                                   
                region02.RegionDescription = "Centro";

                region03.RegionID = 7;                                   
                region03.RegionDescription = "Sul";

                db.Region.Add(region01);                                 // adicionar o novo registo à tabela em memória (dbset)
                db.Region.Add(region02);                                 
                db.Region.Add(region03);                                 

                int contRegions = db.SaveChanges();                       // gravar o novo resgisto na bd.

                Utility.WriteTitle("Region");
                Console.WriteLine($"{contRegions} nova(s) região/regiões gravada(s). \n");

                //Linq para listar as regiões (id - description)
                var queryRegion = db.Region.Select(r => r).OrderBy(r => r.RegionID);
                
                foreach (var item in queryRegion)
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                }
                #endregion
                #region Novo Territory da Region (n)
                Territories territorie01 = new Territories();
                Territories territorie02 = new Territories();
                Territories territorie03 = new Territories();

                territorie01.TerritoryID = "00001";
                territorie01.TerritoryDescription = "Porto";
                territorie01.RegionID = 5;

                territorie02.TerritoryID = "00002";
                territorie02.TerritoryDescription = "Coimbra";
                territorie02.RegionID = 6;

                territorie03.TerritoryID = "00003";
                territorie03.TerritoryDescription = "Portimão";
                territorie03.RegionID = 7;

                db.Territories.Add(territorie01);
                db.Territories.Add(territorie02);
                db.Territories.Add(territorie03);

                int contTerritories = db.SaveChanges();

                Utility.BlockSeparator(2);
                Utility.WriteTitle("Territory");
                Console.WriteLine($"{contTerritories} novo(s) território(s) gravado(s). \n");

                var queryTerritory = db.Territories.Select(t => t).OrderByDescending(t => t.TerritoryID);

                queryTerritory.ToList().ForEach(t => Console.WriteLine($"{t.TerritoryID} - {t.RegionID} - {t.TerritoryDescription}"));
                #endregion

                #region Novo Employee
                //ToDo JPS --> Inserir um empregado com os meus dados num dos novos territórios.

                EmployeeTerritories emloyeeTerritory01 = new EmployeeTerritories();

                #endregion
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
