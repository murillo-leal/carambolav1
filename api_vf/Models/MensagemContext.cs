using Microsoft.EntityFrameworkCore;
using Mensagem.Models;
using Data.Models;
using Microsoft.Data.SqlClient;


namespace Data.Models
{
    public class MsgContex : DbContext
    {
        public MsgContex(DbContextOptions<MsgContex> options)
        : base(options)
        {         

        }
        
        public DbSet<Texto> Data{get; set;}
        public DbSet<Msg> mensagem{get;set;}      
        
    }
}