using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity;
using data;
using MySql.Data.MySqlClient;
using System.Data;


namespace bussiness
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();
        public int insertEmp(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO empRegister VALUES (NULL,'" + info.name + "','" + info.prenom + "','" + info.datnais + "','" + info.Adresse + "','" + info.education + "','" + info.password + "','" + info.username + "' ,'U')";
            return db.ExeNonQuery(cmd);
        }
        public DataTable login(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from empRegister where Username ='" + info.username + "' and Password='" + info.password + "'";
            return db.ExeReader(cmd);
        }
        public DataTable Employees(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * FROM empRegister ";
            return db.ExeReader(cmd);
        }
        public int Supprimeremp(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete FROM empRegister where id ='" + info.f + "'";
            return db.ExeNonQuery(cmd);
        }
        public int modifieremp(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update empRegister set Name='" + info.name + "',Adresse='" + info.Adresse + "',education='" + info.education + "',username='" + info.username + "',Datenais='" + info.datnais + "',password='" + info.password + "',prenom='" + info.prenom + "' where id='" + info.f + "'";

            return db.ExeNonQuery(cmd);
        }
        public int insertarticle(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO article VALUES (NULL,'" + info.nomart + "','" + info.refart + "','" + info.prixunit + "','" + info.Qte + "','" + info.marque + "','" + info.tva + "' )";
            return db.ExeNonQuery(cmd);
        }
        public int Supprimerarticle(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete FROM article where id ='" + info.f + "'";
            return db.ExeNonQuery(cmd);
        }

        public int modifiearticle(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update article set nomart='" + info.nomart + "',refart='" + info.refart + "',prixunit='" + info.prixunit + "',Qte='" + info.Qte + "',marque='" + info.marque + "',tva='" + info.tva + "'";

            return db.ExeNonQuery(cmd);
        }

        public DataTable articles(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from article ";
            return db.ExeReader(cmd);
        }

        public DataTable rechercher(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from article where LIKE  LIKE '%" + info.recherche + "%' ";
            return db.ExeReader(cmd);
        }
    }
}
