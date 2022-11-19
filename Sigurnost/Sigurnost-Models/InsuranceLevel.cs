using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Models
{
    public class InsuranceLevel
    {
        [Key]
        public int InsuranceLevelId { get; set; }

        [Required]
        public string InsuranceLevelName { get; set; }

        [Required]
        public int PercentageAddFromBase { get; set; }
        public virtual IEnumerable<InsuranceContract> InsuranceContracts { get; set; }
    }
}
