using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Models
{
    public class CarInsuranceInfo
    {
        [Key]
        public int CarInsuranceInfoId { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        [Required]
        public uint TalonNumber { get; set; }

        [Required]
        public string CarBrand { get; set; }

        [Required]
        public string CarModel { get; set; }

        [Required]
        public string EngineType { get; set; }

        [Required]
        public string EnginePower { get; set; }

        [Required]
        public DateTime YearOfManifacturing { get; set; }

        [Required]
        public uint CarDroveDistance { get; set; }

        [Required]
        public bool IsUsedForPersonalPurposes { get; set; }

        [Required]
        public int NumOfInsurancesOfOwnerIn10Years { get; set; }

        [Required]
        public bool IsDrivenByUnder24People { get; set; }

        [ForeignKey("InsuranceType"),
            Required]
        public int InsuranceTypeId { get; set; }
        public InsuranceType InsuranceType { get; set; }

        [ForeignKey("InsuranceContract"),
            Required]
        public int InsuranceContractId { get; set; }
        public InsuranceContract InsuranceContract { get; set; }

    }
}
