using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "Machine name can't be left empty")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "Machine number can't be left empty")]
    public int MachineNumber { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }
  }
}