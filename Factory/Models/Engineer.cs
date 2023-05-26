using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    public string EngineerName { get; set; }

    public int EngineerLicense { get; set; }

    public int MachineId { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }

  }
}