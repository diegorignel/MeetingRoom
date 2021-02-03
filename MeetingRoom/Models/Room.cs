using MeetingRoom.Models.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoom.Models
{
    [Table("Room")]
    public class Room : IEntity
    {
        /// <summary>
        /// Id da sala
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Descrição da sala
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Código da sala
        /// </summary>
        public string Code { get; set; }

        public virtual MeetingRoom MeetingRoom { get; set; }
    }
}
