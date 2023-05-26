using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer name can't be left empty")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "Engineer license can't be left empty")]
    public int EngineerLicense { get; set; }
    [Required(ErrorMessage = "Engineer speciality can't be left empty")]
    public string EngineerSpecialty { get; set; }

    public int MachineId { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }

  }
}