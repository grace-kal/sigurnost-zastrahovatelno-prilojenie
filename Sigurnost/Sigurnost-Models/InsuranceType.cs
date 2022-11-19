using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Models
{
    public class InsuranceType
    {
        [Key]
        public int InsuranceTypeId { get; set; }

        [Required]
        public string InsuranceTypeName { get; set; }
        public virtual IEnumerable<CarInsuranceInfo> CarInsuranceInfos { get; set; }
        public virtual IEnumerable<HomeInsuranceInfo> HomeInsuranceInfos { get; set; }
    }
}
