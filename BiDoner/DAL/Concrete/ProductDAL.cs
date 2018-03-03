using BiDoner.DAL.Abstract;
using BiDoner.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiDoner.DAL.Concrete
{
    public class ProductDAL : Connection, IProductDAL
    {
        public int Add(Product entity)
        {

            try
            {
                using (var con = GetConnection)
                {
                    string sql = @"INSERT INTO Products (CategoryId,ProductName,Description,Price,PictureUrl,IsActive) VALUES (@CategoryId,@ProductName,@Description,@Price,@PictureUrl,@IsActive)" + " SELECT CAST(SCOPE_IDENTITY() as int)";
                    int id = con.Query<int>(sql, entity).Single();
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
                    string query = @"DELETE FROM Products WHERE ProductId='" + id + "'";
                    con.Execute(query);

                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public Product Get(string id)
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Products Where ProductId='" + id + "'";
                    return con.Query<Product>(query).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Products Where IsActive='true'";
                    return con.Query<Product>(query).ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Product> GetAll()
        {

            try
            {
                using (var con = GetConnection)
                {
                    string query = @"Select * From Products";
                    return con.Query<Product>(query).ToList();                 
                }
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        public bool Update(Product entity)
        {
            try
            {
                using (var con = GetConnection)
                {
                    string query = @"UPDATE Products SET CategoryId=@CategoryId,ProductName=@ProductName,Description=@Description,Price=@Price,PictureUrl=@PictureUrl,IsActive=@IsActive WHERE ProductId=@ProductId";
                    con.Execute(query, entity);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}