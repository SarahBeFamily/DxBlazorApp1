using System.ComponentModel.DataAnnotations;

namespace DxBlazorApp1.Components.Pages
{
    public class RegistrationDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string? Name { get; set; }

        [Required]
        [StringLength(256)]
        public string? Surname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string? Email { get; set; }

        [StringLength(20, MinimumLength = 6)]
        public string? MobileNumber { get; set; }

        public string? VerificationCode { get; set; }

        public string? VerificationUrl { get; set; }

        public bool MatchSedeOperativa { get; set; } = false;


        public LocationOperativa SedeOperativa { get; set; } = new LocationOperativa();

        [Required]
        [StringLength(100)]
        public string? SedeLegaleCompanyName { get; set; }


        [Required]
        public Guid? SedeLegaleLegalStructureId { get; set; }


        [Required]
        [StringLength(16, MinimumLength = 11)]
        public string? SedeLegaleFiscalCode { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 11)]
        public string? SedeLegaleVatNum { get; set; }

        [Required]
        [StringLength(255)]
        public string? SedeLegaleAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string? SedeLegaleCity { get; set; }

        [Required]
        public Guid? SedeLegaleProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        public string? SedeLegaleZIPcode { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string? SedeLegaleCompanyEmail { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string? SedeLegaleCompanyPhoneNumber { get; set; }

        [Required]
        public Guid? AtecoId { get; set; }

        public bool PrivacyAccepted { get; set; } = false;

        public bool TermsAccepted { get; set; } = false;

        public class LocationOperativa
        {
            [StringLength(100)]
            public string? CompanyName { get; set; }

            [StringLength(255)]
            public string? Address { get; set; }

            [StringLength(50)]
            public string? City { get; set; }

            public Guid? ProvinceId { get; set; }

            [StringLength(50)]
            public string? ZIPcode { get; set; }

            [EmailAddress]
            [StringLength(256)]
            public string? CompanyEmail { get; set; }

            [StringLength(20, MinimumLength = 6)]
            public string? CompanyPhoneNumber { get; set; }

            public Guid? AtecoId { get; set; }
        }
    }
}
