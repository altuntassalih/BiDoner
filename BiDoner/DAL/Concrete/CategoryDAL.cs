using BiDoner.DAL.Abstract;
using BiDoner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiDoner.DAL.Concrete
{
    public class CategoryDAL :Connection,ICategoryDAL
    {
        public int Add(Category entity)
        {

            try
            {
                using (var con = GetConnection)
                {
                    string query = @"INSERT INTO Categories (CategoryName,Description,PictureUrl,IsActive) VALUES (@CategoryName,@Description,@PictureUrl,@IsActive)" + " SELECT CAST(SCOPE_IDENTITY() as int)";
                    int id = con.Query<int>(query, entity).Single();
                    return id;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"DELETE FROM Categories WHERE CategoryId='" + id + "'";
                    con.Execute(query);

                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public Category Get(string id)
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Categories Where CategoryId='" + id + "'";
                    return con.Query<Category>(query).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

   

        public List<Category> GetAll()
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Categories ";
                    return con.Query<Category>(query).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Update(Category entity)
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"UPDATE Categories SET CategoryName=@CategoryName,Description=@Description,PictureUrl=@PictureUrl,IsActive=@IsActive WHERE CategoryId=@CategoryId";
                    con.Execute(query, entity);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Category> GetAllActiveCategories()
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Categories Where IsActive='true'";
                    
                    return con.Query<Category>(query).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}