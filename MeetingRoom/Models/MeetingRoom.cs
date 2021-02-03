using MeetingRoom.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Models
{
    [Table("MeetingRoom")]
    public class MeetingRoom : IEntity
    {
        /// <summary>
        /// Id do agendamento da sala de reunião
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Título do agendamento da sala de reunião
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Data de início do agendamento
        /// </summary>
        [Required]
        public DateTime StartingDate { get; set; }

        /// <summary>
        /// Data de término do agendamento
        /// </summary>
        [Required]
        public DateTime EndingDate { get; set; }

        public virtual Room Room { get; set; }

        [ForeignKey("Student")]
        public int RoomId { get; set; }
    }
}
