using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _typeStrings = Sigurnost_Models.TypeStrings;

namespace Sigurnost_Models
{
    public class HomeInsuranceInfo
    {
        [Key]
        public int HomeInsuranceInfoId { get; set; }

        [Required]
        public string TypeOfProperty { get; set; }

        [Required]
        public string PropertyAddress { get; set; }

        [Required]
        public bool IsPermamentAddress { get; set; }

        [Required]
        public DateTime YearOfBuild { get; set; }

        [Required]
        public uint ValueOfTheContent { get; set; }

        [Required]
        public bool PropertyClaimsinLast5Years { get; set; }

        //само движимо(content)
        public bool TheMovablePropIsInTheHome { get; set; }

        //само недвижимо
        //движимо и недвижимо
        public int PropertySizeM2 { get; set; }
        public bool IsApartment { get; set; }
        public bool IsPermanentPlaceOfLiving { get; set; }

        [ForeignKey("InsuranceType"),
            Required]
        public int InsuranceTypeId { get; set; }
        public virtual InsuranceType InsuranceType { get; set; }

        [ForeignKey("InsuranceContract"), 
            Required]
        public int InsuranceContractId { get; set; }
        public virtual InsuranceContract InsuranceContract { get; set; }
    }
}
