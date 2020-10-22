using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Models;
using Microsoft.Data.SqlClient;

namespace Mensagem.Models
{
    public class Texto
    {      
        public Msg data{get; set;}
    }
    
}