﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListAPI.Data.Dtos
{
    public class ReadTarefaDto
    {
        [Key]
        [Required]

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Tarefa não pode estar vázio")]
        public string NomeDaTarefa { get; set; }

        public DateTime Data { get; set; }

    }
}
