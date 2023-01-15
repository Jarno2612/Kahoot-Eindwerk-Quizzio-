using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserGame
    {
        public Guid Id { get; set; }
        public int Score { get; set; }
        public Game? Game { get; }
        public User? User { get; }
        public Guid UserId { get; }
        public Guid GameId { get; }

    }
}
